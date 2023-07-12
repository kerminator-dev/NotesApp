using System;

namespace NotesApp.Models
{
    public class Note
    {
        public string ID { get; set; }
        // Загоетки
        public string Title { get; set; }

        // Оснот заметки
        public string Content { get; set; }

        // Дата заметки
        public DateTime Created { get; set; }

        public Note(string id, string title, string content, DateTime created)
        {
            ID = id;
            Title = title;
            Content = content;
            Created = created;
        }
    }
}
