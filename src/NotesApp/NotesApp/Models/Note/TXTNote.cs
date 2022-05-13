using System;

namespace NotesApp.Models.Note
{
    public class TXTNote : INote
    {
        /// <summary>
        /// Путь к .txt файлу, соответствующему данной заметке
        /// </summary>
        private string _filePath = string.Empty;

        public string ID { get => _filePath; set => _filePath = value; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }

        public TXTNote(string id, string title, string content, DateTime created)
        {
            ID = id;
            Title = title;
            Content = content;
            Created = created;
        }
    }
}
