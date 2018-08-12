using Avalonia;
using Avalonia.Logging.Serilog;
using Itenium.FreelanceJobs.DataAccess;
using Microsoft.Extensions.Configuration;

namespace Itenium.FreelanceJobs.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            BuildAvaloniaApp().Start<MainWindow>();
        }

        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .LogToDebug();
    }
}
