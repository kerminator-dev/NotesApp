using NotesApp.Models.Note;
using System.Collections.Generic;

namespace NotesApp.Data
{
    public interface IDataSource
    {
        // Получить заметку по ID
        public INote GetNote(string id);
        // Получить список всех заметок
        public IEnumerable<INote> GetAllNotes();
        // Получить список недавних заметок
        public IEnumerable<INote> GetRecentNotes();
        // Получить список старых заметок
        public IEnumerable<INote> GetOldNotes();
        // Сохранить заметку
        public void SaveNote(INote noteToSave);
        // Найти заметки
        public IEnumerable<INote> SearchNotes(string valueToSearch);
        // Удалить заметку
        public void DeleteNote(string id);
        public INote GetEmptyNote();
    }
}
