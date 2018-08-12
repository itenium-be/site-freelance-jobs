namespace Itenium.FreelanceJobs.DataAccess.Models
{
    public class GitCredentials
    {
        public string Username { get; set; }
        public string Email { get; set; }

        public override string ToString() => $"{Username} ({Email}";
    }
}