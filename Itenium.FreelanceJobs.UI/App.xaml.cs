using Avalonia;
using Avalonia.Markup.Xaml;

namespace Itenium.FreelanceJobs.UI
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
