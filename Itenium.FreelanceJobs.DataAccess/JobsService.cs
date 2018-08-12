using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Metadata;
using Itenium.FreelanceJobs.DataAccess.Models;
using LibGit2Sharp;
using YamlDotNet.RepresentationModel;
using YamlDotNet.Serialization;

namespace Itenium.FreelanceJobs.DataAccess
{
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
            }
            else
            {
                var repo = new Repository(_settings.ClonePath); // todo: using
                var signature = new Signature(new Identity(_creds.Username, _creds.Email), DateTimeOffset.Now);
                Commands.Pull(repo, signature, new PullOptions()
                {
                    FetchOptions = new FetchOptions() { }
                });
            }

            var freelanceJobs = ReadYaml();
            return freelanceJobs;
        }

        private IEnumerable<FreelanceJob> ReadYaml()
        {
            var deserializer = new DeserializerBuilder().Build();
            var jobs = deserializer.Deserialize<IEnumerable<FreelanceJob>>(File.OpenText(_settings.JobsYaml));
            return jobs;
        }
    }
}
