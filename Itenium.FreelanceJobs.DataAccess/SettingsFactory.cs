using System.Data;
using System.IO;
using Itenium.FreelanceJobs.DataAccess.Models;
using Microsoft.Extensions.Configuration;

namespace Itenium.FreelanceJobs.DataAccess
{
    public class SettingsFactory
    {
        private readonly IConfigurationRoot _config;

        public SettingsFactory()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            _config = builder.Build();
        }

        public SourceSettings GetSourceSettings()
        {
            var settings = new SourceSettings(Directory.GetCurrentDirectory())
            {
                GitRepository = _config["source:GitRepository"],
                GitBranch = _config["source:GitBranch"],
                ClonePath = _config["source:ClonePath"],
                JobsYaml = _config["source:JobsYaml"],
            };
            return settings;
        }

        public GitCredentials GetGitCredentials()
        {
            var creds = new GitCredentials()
            {
                Username = _config["creds:Username"],
                Email = _config["creds:Email"],
            };
            return creds;
        }
    }
}