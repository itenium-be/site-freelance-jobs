using System;
using YamlDotNet.Serialization;

namespace Itenium.FreelanceJobs.DataAccess.Models
{
    public class FreelanceJob
    {
        private static int _newId;
        private string _title;

        public FreelanceJob()
        {
            Id = ++_newId;
            DateAdded = DateTime.Now.Date;
        }

        [YamlMember(Alias = "id")]
        public int Id { get; set; }

        [YamlMember(Alias = "title")]
        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                Slug = Slugify.GenerateSlug(value);
            }
        }

        [YamlMember(Alias = "location")]
        public string Location { get; set; }

        [YamlMember(Alias = "description")]
        public string Description { get; set; }

        [YamlMember(Alias = "username")]
        public string Username { get; set; }

        [YamlMember(Alias = "date")]
        public DateTime DateAdded { get; set; }

        [YamlMember(Alias = "published")]
        public bool Published { get; set; }

        [YamlMember(Alias = "slug")]
        public string Slug { get; set; }

        public override string ToString() => $"{Title} ({Location})";
    }
}