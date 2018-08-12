using System;
using System.Collections.Generic;
using System.Text;

namespace Itenium.FreelanceJobs.DataAccess
{
    public static class JobsServiceFactory
    {
        public static JobsService GetService()
        {
            var setsFactory = new SettingsFactory();
            var creds = setsFactory.GetGitCredentials();
            var settings = setsFactory.GetSourceSettings();
            var service = new JobsService(creds, settings);
            return service;
        }
    }
}
