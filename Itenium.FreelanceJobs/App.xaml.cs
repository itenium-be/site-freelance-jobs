using Avalonia;
using Avalonia.Markup.Xaml;

namespace Itenium.FreelanceJobs
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
