namespace NotesApp.Models
{
    public class Notification
    {
        /// <summary>
        /// Заголовок уведомления
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Текст кнопки
        /// </summary>
        public string ButtonText { get; set; }

        /// <summary>
        /// Уведомление
        /// </summary>
        /// <param name="title"></param>
        public Notification(string title) : this(title, "Закрыть") { }

        public Notification(string title, string buttonText)
        {
            Title = title;
            ButtonText = buttonText;
        }
    }
}
