namespace Itenium.FreelanceJobs.DataAccess.Models
{
    internal class GitCredentials
    {
        public string Username { get; set; }
        public string Email { get; set; }

        public override string ToString() => $"{Username} ({Email}";
    }
}