using System.IO;

namespace Itenium.FreelanceJobs.DataAccess.Models
{
    public class SourceSettings
    {
        private string _clonePath;
        private readonly string _basePath;

        public SourceSettings(string basePath)
        {
            _basePath = basePath;
        }

        public string GitRepository { get; set; }
        public string GitBranch { get; set; }

        public string ClonePath
        {
            get => _clonePath;
            set => _clonePath = Path.Combine(_basePath, value);
        }

        public string JobsYaml
        {
            get => Path.Combine(ClonePath, RelativeJobYaml);
            set => RelativeJobYaml = value;
        }

        public string RelativeJobYaml { get; private set; }

        public override string ToString() => $"{JobsYaml}";
    }
}