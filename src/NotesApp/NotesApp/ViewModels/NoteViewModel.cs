using NotesApp.Extensions;
using NotesApp.Models.Note;

namespace NotesApp.ViewModels
{
    /// <summary>
    /// ViewModel для ControlTemplate - карточки, представляющей заметку
    /// </summary>
    public class NoteViewModel : ViewModelBase
    {
        private readonly INote _note;

        /// <summary>
        /// ID заметки
        /// </summary>
        public string ID => _note.ID;

        /// <summary>
        /// Заголовок заметки с ограничением в 50 символов
        /// </summary>
        public string ShortTitle => _note.Title.Substring(47, "...");

        /// <summary>
        /// Основной текст размерностью в 90 символов
        /// </summary>
        public string ShortContent => _note.Content.Substring(87, "...");

        /// <summary>
        /// Краткая запись даты создания
        /// </summary>
        public string ShortCreated => _note.Created.ToShortDateTimeString();

        public NoteViewModel(INote note)
        {
            _note = note;
        }
    }
}
