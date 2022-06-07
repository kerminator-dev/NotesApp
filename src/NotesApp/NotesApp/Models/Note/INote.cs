using System;

namespace NotesApp.Models.Note
{
    public interface INote
    {
        public string ID { get; set; }
        // Загоетки
        public string Title { get; set; }

        // Оснот заметки
        public string Content { get; set; }

        // Дата заметки
        public DateTime Created { get; set; }
    }
}
