using NotesApp.Extensions;
using NotesApp.Models.Note;

namespace NotesApp.ViewModels
{
    internal class CardControlViewModel
    {
        private readonly INote _note;

        /// <summary>
        /// ID заметки
        /// </summary>
        public string ID
        {
            get => _note.ID;
        }

        /// <summary>
        /// Заголовок заметки с ограничением в 50 символов
        /// </summary>
        public string ShortTitle
        {
            get => _note.Title.Substring(47, "...");
        }

        /// <summary>
        /// Основной текст размерностью в 90 символов
        /// </summary>
        public string ShortContent
        {
            get => _note.Content.Substring(87, "...");
        }

        /// <summary>
        /// Краткая запись даты создания
        /// </summary>
        public string ShortCreated
        {
            get => _note.Created.ToShortDateTimeString();
        }

        public CardControlViewModel(INote note)
        {
            _note = note;
        }
    }
}
