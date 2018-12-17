using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Itenium.FreelanceJobs.DataAccess.Models;
using LibGit2Sharp;
using LibGit2Sharp.Handlers;
using Microsoft.Alm.Authentication;
using YamlDotNet.RepresentationModel;
using YamlDotNet.Serialization;

namespace Itenium.FreelanceJobs.DataAccess
{
    internal class JobsService : IJobsService
    {
        private readonly GitCredentials _creds;
        private readonly SourceSettings _settings;

        public JobsService(GitCredentials creds, SourceSettings settings)
        {
            _creds = creds;
            _settings = settings;
        }

        #region Getting
        public IEnumerable<FreelanceJob> GetJobs()
        {
            if (!Directory.Exists(_settings.ClonePath))
            {
                CloneRepo();
            }
            else
            {
                PullRepo();
            }

            var freelanceJobs = ReadYaml();
            return freelanceJobs;
        }
        #endregion

        #region Saving
        public void SaveJobs(ICollection<FreelanceJob> jobs, FreelanceJob changedJob, ChangeType type)
        {
            //var sw = Stopwatch.StartNew();

            foreach (var job in jobs.Where(j => string.IsNullOrWhiteSpace(j.Username)))
                job.Username = _creds.Username;

            PullRepo();
            WriteYaml(jobs);
            WritePages(jobs);

            //sw.Stop();
            //var elapsed = sw.Elapsed.ToString("g");
            //Debug.WriteLine("Elapsed: " + elapsed);

            //sw.Restart();
            Task.Run(() => CommitAndPush(GetCommitMessage(changedJob, type)));
            //var elapsedPushTime = sw.Elapsed.ToString("g");
        }

        private void WritePages(IEnumerable<FreelanceJob> jobs)
        {
            var dir = new DirectoryInfo(_settings.PagesPath);
            foreach (var file in dir.EnumerateFiles("*.html"))
            {
                file.Delete();
            }

            var template = File.ReadAllText(_settings.PageTemplate);
            var templateDeleted = File.ReadAllText(_settings.PageTemplateDeleted);

            foreach (var job in jobs)
            {
                var jobPage = job.Published ? template : templateDeleted;
                jobPage = jobPage.Replace("{id}", job.Id.ToString());
                jobPage = jobPage.Replace("{slug}", job.Slug);
                jobPage = jobPage.Replace("{title}", job.Title.Replace("\"", "\\\""));
                jobPage = jobPage.Replace("{location}", job.Location);

                File.WriteAllText(Path.Combine(dir.FullName, $"{job.Id}.html"), jobPage);
            }
        }
        #endregion

        #region Yaml
        private IEnumerable<FreelanceJob> ReadYaml()
        {
            var deserializer = new DeserializerBuilder().Build();
            using (var file = File.OpenText(_settings.JobsYaml))
            {
                var jobs = deserializer.Deserialize<IEnumerable<FreelanceJobDto>>(file);
                return jobs.Select(MapToModel());
            }
        }

        private void WriteYaml(IEnumerable<FreelanceJob> jobs)
        {
            var serializer = new SerializerBuilder().Build();
            using (var file = File.CreateText(_settings.JobsYaml))
            {
                var yamlJobs = jobs.Select(MapToDto());
                serializer.Serialize(file, yamlJobs);
            }
        }
        #endregion

        #region Mapping
        private static Func<FreelanceJobDto, FreelanceJob> MapToModel()
        {
            return yamlJob => new FreelanceJob()
            {
                DateAdded = yamlJob.DateAdded,
                Description = yamlJob.Description,
                Id = yamlJob.Id,
                Location = yamlJob.Location,
                Title = yamlJob.Title,
                UnpublishDate = yamlJob.UnpublishDate,
                Username = yamlJob.Username,
                Slug = yamlJob.Slug,
            };
        }

        private static Func<FreelanceJob, FreelanceJobDto> MapToDto()
        {
            return modelJob => new FreelanceJobDto()
            {
                DateAdded = modelJob.DateAdded,
                Description = modelJob.Description,
                Id = modelJob.Id,
                Location = modelJob.Location,
                Title = modelJob.Title,
                UnpublishDate = modelJob.UnpublishDate,
                Username = modelJob.Username,
                Slug = modelJob.Slug,
                Published = modelJob.Published,
            };
        }
        #endregion

        #region Git
        private void CloneRepo()
        {
            Repository.Clone(_settings.GitRepository, _settings.ClonePath);
            using (var repo = new Repository(_settings.ClonePath))
            {
                var branch = repo.Branches[_settings.GitBranch];
                Commands.Checkout(repo, branch);
            }
        }

        private void PullRepo()
        {
            using (var repo = new Repository(_settings.ClonePath))
            {
                Commands.Pull(repo, GetGitSignature(), new PullOptions()
                {
                    FetchOptions = new FetchOptions() { }
                });
            }
        }

        private static readonly object GitPushLock = new object();

        private void CommitAndPush(string commitMsg)
        {
            lock (GitPushLock)
            using (var repo = new Repository(_settings.ClonePath))
            {
                // STAGE & COMMIT
                Commands.Stage(repo, "*");
                repo.Commit(commitMsg, GetGitSignature(), GetGitSignature(), new CommitOptions());

                // PUSH
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
                repo.Network.Push(repo.Branches[_settings.GitBranch], options);
            }
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

        private Signature GetGitSignature()
        {
            return new Signature(new Identity(_creds.Username, _creds.Email), DateTimeOffset.Now);
        }
        #endregion
    }
}
