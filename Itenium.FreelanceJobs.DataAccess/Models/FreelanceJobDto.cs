using System;
using YamlDotNet.Serialization;

namespace Itenium.FreelanceJobs.DataAccess.Models
{
    /// <summary>
    /// The Model saved as yaml
    /// </summary>
    internal class FreelanceJobDto
    {
        [YamlMember(Alias = "id")]
        public int Id { get; set; }

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

        [YamlMember(Alias = "unpublishdate")]
        public DateTime UnpublishDate { get; set; }

        [YamlMember(Alias = "published")]
        public bool Published { get; set; }

        [YamlMember(Alias = "slug")]
        public string Slug { get; set; }

        public override string ToString() => $"{Title} ({Location})";
    }
}