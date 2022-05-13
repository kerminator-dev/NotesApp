using System;

namespace NotesApp.Models.Note
{
    public class SQLiteNote : INote
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }

        public SQLiteNote(string id, string title, string content, DateTime created)
        {
            ID = id;
            Title = title;
            Content = content;
            Created = created;
        }
    }
}
