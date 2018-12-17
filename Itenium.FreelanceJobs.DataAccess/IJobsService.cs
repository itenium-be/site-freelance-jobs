using System.Collections.Generic;
using Itenium.FreelanceJobs.DataAccess.Models;

namespace Itenium.FreelanceJobs.DataAccess
{
    /// <summary>
    /// Get and save jobs
    /// </summary>
    public interface IJobsService
    {
        IEnumerable<FreelanceJob> GetJobs();
        void SaveJobs(ICollection<FreelanceJob> jobs, FreelanceJob changedJob, ChangeType type);
    }
}