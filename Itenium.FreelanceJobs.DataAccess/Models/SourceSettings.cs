using System.IO;

namespace Itenium.FreelanceJobs.DataAccess.Models
{
    public class SourceSettings
    {
        private string _clonePath;
        private string _jobsYaml;
        private readonly string _basePath;

        public SourceSettings(string basePath)
        {
            _basePath = basePath;
        }

        public string GitRepository { get; set; }
        public string GitBranch { get; set; } // todo: not actually used

        public string ClonePath
        {
            get => _clonePath;
            set => _clonePath = Path.Combine(_basePath, value);
        }

        public string JobsYaml
        {
            get => _jobsYaml;
            set => _jobsYaml = Path.Combine(ClonePath, value);
        }

        public override string ToString() => $"{JobsYaml}";
    }
}