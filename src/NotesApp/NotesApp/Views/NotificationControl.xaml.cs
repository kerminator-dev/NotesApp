using NotesApp.Models;
using NotesApp.ViewModels;

namespace NotesApp.Views
{
    /// <summary>
    /// Логика взаимодействия для NotificationControl.xaml
    /// </summary>
    public partial class NotificationControl
    {
        private readonly NotificationControlViewModel _viewModel;

        public NotificationControl(Notification notification)
        {
            InitializeComponent();

            _viewModel = new NotificationControlViewModel(notification);
            DataContext = _viewModel;
        }
    }
}
