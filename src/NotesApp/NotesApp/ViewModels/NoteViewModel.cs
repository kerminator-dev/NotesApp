using NotesApp.Commands;
using System.Windows.Input;

namespace NotesApp.ViewModels
{
    /// <summary>
    /// ViewModel для ControlTemplate - карточки, представляющей заметку
    /// </summary>
    public class NoteViewModel : ViewModelBase
    {
        // private readonly Note _note;

        /// <summary>
        /// ID заметки
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// Заголовок заметки с ограничением в 50 символов
        /// </summary>
        public string ShortTitle { get; set; }

        /// <summary>
        /// Основной текст размерностью в 90 символов
        /// </summary>
        public string ShortContent { get; set; }

        /// <summary>
        /// Краткая запись даты создания
        /// </summary>
        public string ShortCreated { get; set; }
    }
}
