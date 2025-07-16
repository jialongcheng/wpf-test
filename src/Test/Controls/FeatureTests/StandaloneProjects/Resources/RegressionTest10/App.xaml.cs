using System.Windows;

namespace Microsoft.Test.Controls
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            WpfgfxLoader.Load();
        }

    }
}
