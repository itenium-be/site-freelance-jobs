using System;
using System.IO;
using Itenium.FreelanceJobs.DataAccess;
using Itenium.FreelanceJobs.DataAccess.Models;
using Microsoft.Extensions.Configuration;

namespace Itenium.FreelanceJobs.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = JobsServiceFactory.GetService();
            var result = service.GetJobs();
            var x = result;

        }
    }
}
