﻿using System.IO;

namespace Itenium.FreelanceJobs.DataAccess.Models
{
    internal class SourceSettings
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

        public string PageTemplate
        {
            get => Path.Combine(ClonePath, RelativePageTemplate);
            set => RelativePageTemplate = value;
        }

        public string PageTemplateDeleted
        {
            get => Path.Combine(ClonePath, RelativePageTemplateDeleted);
            set => RelativePageTemplateDeleted = value;
        }

        public string PagesPath
        {
            get => Path.Combine(ClonePath, RelativePagesPath);
            set => RelativePagesPath = value;
        }

        public string RelativeJobYaml { get; private set; }
        public string RelativePageTemplate { get; private set; }
        public string RelativePageTemplateDeleted { get; private set; }
        public string RelativePagesPath { get; private set; }

        public override string ToString() => $"{JobsYaml}";
    }
}