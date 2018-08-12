using System;
using YamlDotNet.Serialization;

namespace Itenium.FreelanceJobs.DataAccess.Models
{
    public class FreelanceJob
    {
        [YamlMember(Alias = "title")]
        public string Title { get; set; }

        [YamlMember(Alias = "location")]
        public string Location { get; set; }

        [YamlMember(Alias = "description")]
        public string Description { get; set; }

        [YamlMember(Alias = "username")]
        public string Username { get; set; }

        [YamlMember(Alias = "date")]
        public DateTime DateAdded { get; set; }

        public override string ToString() => $"{Title} ({Location})";
    }
}