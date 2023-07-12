using Microsoft.Extensions.DependencyInjection;
using NotesApp.Data.Repositories;
using NotesApp.Mappings;
using NotesApp.Services.Implementation;
using NotesApp.Services.Interfaces;
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
        private ServiceProvider _serviceProvider;


        public App()
        {
            ServiceCollection services = new ServiceCollection();
            ConfigureServices(services);
            _serviceProvider = services.BuildServiceProvider();
        }

        protected void ConfigureServices(ServiceCollection services)
        {
            services.AddAutoMapper(typeof(MappingProfile));
            services.AddSingleton<INoteRepository, SQLiteAdoNoteRepository>();
            services.AddSingleton<INoteService, DefaultNoteService>();
            services.AddSingleton<MainWindow>();
            services.AddSingleton<MainWindowViewModel>();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = _serviceProvider.GetService<MainWindow>();
            var viewModel = _serviceProvider.GetService<MainWindowViewModel>();
            viewModel.LoadNotes();
            MainWindow.DataContext = viewModel;

            MainWindow?.Show();

            base.OnStartup(e);
        }
    }
}
