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
            MainWindowViewModel viewModel = new MainWindowViewModel();
            MainWindow = new MainWindow
            (
                viewModel
            );
            MainWindow.DataContext = viewModel;
            MainWindow.Show();


            base.OnStartup(e);
        }
    }
}
