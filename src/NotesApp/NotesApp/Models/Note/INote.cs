using System;

namespace NotesApp.Models.Note
{
    public interface INote
    {
        public string ID { get; set; }
        // Заголовок заметки
        public string Title { get; set; }

        // Основной текст заметки
        public string Content { get; set; }

        // Дата создания заметки
        public DateTime Created { get; set; }
    }
}
