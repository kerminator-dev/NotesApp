using NotesApp.ViewModels;
using NotesApp.Views;
using System.Windows;

namespace NotesApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = CreateMainWindow();
            MainWindow.Show();

            base.OnStartup(e);
        }

        private MainWindow CreateMainWindow()
        {
            var viewModel = new MainWindowViewModel();
            var window = new MainWindow(viewModel);
            window.DataContext = viewModel;

            return window;
        }
    }
}
