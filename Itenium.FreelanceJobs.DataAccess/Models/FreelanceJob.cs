using System;
using YamlDotNet.Serialization;

namespace Itenium.FreelanceJobs.DataAccess.Models
{
    public class FreelanceJob
    {
        private static readonly TimeSpan DefaultPublishedTime = TimeSpan.FromDays(30);
        private string _title;
        private DateTime _dateAdded;

        public FreelanceJob()
        {
            DateAdded = DateTime.Now;
        }

        public int Id { get; set; }

        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                Slug = Slugify.GenerateSlug(value);
            }
        }

        public string Location { get; set; }

        public string Description { get; set; }

        public string Username { get; set; }

        public DateTime DateAdded
        {
            get => _dateAdded;
            set
            {
                _dateAdded = value;
                UnpublishDate = _dateAdded.Add(DefaultPublishedTime);
            }
        }

        public DateTime UnpublishDate { get; set; }

        public bool Published
        {
            get => DateTime.Now < UnpublishDate;
            set => UnpublishDate = value ? _dateAdded.Add(DefaultPublishedTime) : DateTime.Now.Date;
        }

        public string Slug { get; set; }

        
        public override string ToString() => $"{Id}: {Title} ({Location})";
    }
}