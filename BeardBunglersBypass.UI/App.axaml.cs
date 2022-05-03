using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using BeardBunglersBypass.Core;
using BeardBunglersBypass.ViewModels;
using BeardBunglersBypass.Views;

namespace BeardBunglersBypass
{
    public partial class App : Application
    {
        public override void Initialize()
        {
            new Class1();
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = new MainWindow
                {
                    DataContext = new MainWindowViewModel(),
                };
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}