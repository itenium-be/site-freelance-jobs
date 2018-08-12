using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Itenium.FreelanceJobs.DataAccess.Models;
using LibGit2Sharp;
using LibGit2Sharp.Handlers;
using Microsoft.Alm.Authentication;
using YamlDotNet.RepresentationModel;
using YamlDotNet.Serialization;

namespace Itenium.FreelanceJobs.DataAccess
{
    public enum ChangeType
    {
        Published,
        Updated,
        Removed,
    }

    public class JobsService
    {
        private readonly GitCredentials _creds;
        private readonly SourceSettings _settings;

        public JobsService(GitCredentials creds, SourceSettings settings)
        {
            _creds = creds;
            _settings = settings;
        }

        public IEnumerable<FreelanceJob> GetJobs()
        {
            if (!Directory.Exists(_settings.ClonePath))
            {
                Repository.Clone(_settings.GitRepository, _settings.ClonePath);
                using (var repo = new Repository(_settings.ClonePath))
                {
                    var branch = repo.Branches[_settings.GitBranch];
                    Commands.Checkout(repo, branch);
                }
            }
            else
            {
                using (var repo = new Repository(_settings.ClonePath))
                {
                    Commands.Pull(repo, GetGitSignature(), new PullOptions()
                    {
                        FetchOptions = new FetchOptions() { }
                    });
                }
            }

            var freelanceJobs = ReadYaml();
            return freelanceJobs;
        }

        private IEnumerable<FreelanceJob> ReadYaml()
        {
            var deserializer = new DeserializerBuilder().Build();
            using (var file = File.OpenText(_settings.JobsYaml))
            {
                var jobs = deserializer.Deserialize<IEnumerable<FreelanceJob>>(file);
                return jobs;
            }
        }

        private void WriteYaml(IEnumerable<FreelanceJob> jobs)
        {
            var serializer = new SerializerBuilder().Build();
            using (var file = File.CreateText(_settings.JobsYaml))
                serializer.Serialize(file, jobs);
        }

        public void SaveJobs(ICollection<FreelanceJob> jobs, FreelanceJob changedJob, ChangeType type)
        {
            foreach (var job in jobs.Where(j => !string.IsNullOrWhiteSpace(j.Username)))
                job.Username = _creds.Username;

            WriteYaml(jobs);
            CommitAndPush(GetCommitMessage(changedJob, type));
        }

        private static string GetCommitMessage(FreelanceJob job, ChangeType type)
        {
            string prefix = $"Freelance job '{job.Title}'";
            switch (type)
            {
                case ChangeType.Published:
                    return prefix + " has been published";
                case ChangeType.Removed:
                    return prefix + " has been unpublished";
                default:
                    return prefix + " has been updated";
            }
        }

        private void CommitAndPush(string commitMsg)
        {
            using (var repo = new Repository(_settings.ClonePath))
            {
                Commands.Stage(repo, "*");
                repo.Commit(commitMsg, GetGitSignature(), GetGitSignature(), new CommitOptions());


                //Remote remote = repo.Network.Remotes["origin"];
                //var options = new PushOptions();
                //options.CredentialsProvider = (_url, _user, _cred) =>
                //    new UsernamePasswordCredentials { Username = _creds.Username, Password = _creds.Password };
                //repo.Network.Push(remote, $"refs/heads/{_settings.GitBranch}", options);

                //LibGit2Sharp.PushOptions options = new LibGit2Sharp.PushOptions();
                var secrets = new SecretStore("git");
                var auth = new BasicAuthentication(secrets);
                var creds = auth.GetCredentials(new TargetUri("https://github.com"));
                var options = new PushOptions
                {
                    CredentialsProvider = (_url, _user, _cred) => new UsernamePasswordCredentials
                    {
                        Username = creds.Username,
                        Password = creds.Password
                    },
                };

                //options.CredentialsProvider = new CredentialsHandler(
                //    (url, usernameFromUrl, types) =>
                //        new UsernamePasswordCredentials()
                //        {
                //            Username = _creds.Username,
                //            Password = _creds.Password
                //        });
                repo.Network.Push(repo.Branches[_settings.GitBranch], options);
            }
        }

        private Signature GetGitSignature()
        {
            return new Signature(new Identity(_creds.Username, _creds.Email), DateTimeOffset.Now);
        }
    }
}
