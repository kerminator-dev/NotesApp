using NotesApp.Models;

namespace NotesApp.ViewModels
{
    public class NotificationControlViewModel
    {
        private readonly Notification _notification;

        /// <summary>
        /// Заголовок уведомления
        /// </summary>
        public string Title
        {
            get => _notification.Title;
        }

        /// <summary>
        /// Текст кнопки
        /// </summary>
        public string ButtonText
        {
            get => _notification.ButtonText;
        }

        public NotificationControlViewModel(Notification notification)
        {
            _notification = notification;
        }
    }
}
