using System.Configuration;
using System.Data;
using System.Windows;

namespace BaseWpfApp4
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            //var bootstrapper = new Bootstrapper();
            //var container = bootstrapper.Bootstrap();

            //var loginWindow = container.Resolve<LoginDetailView>();
            //loginWindow.Show();

            //var mainWindow = container.Resolve<MainWindow>();
            //mainWindow.Show();
        }

        private void Application_DispatcherUnhandledException(object sender,
          System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show("Unexpected error occured. Please inform the admin."
              + Environment.NewLine + e.Exception.Message, "Unexpected error");

            e.Handled = true;
        }
    }



}
