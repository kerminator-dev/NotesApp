using NotesApp.Models;
using System.Collections.Generic;

namespace NotesApp.Data.Repositories
{
    /// <summary>
    /// Интерфейс, описывающий контракт для работы с разными иточниками данных заметок
    /// </summary>
    public interface INoteRepository
    {
        /// <summary>
        /// Получить заметку по ID
        /// </summary>
        /// <param name="id">ID заметки</param>
        /// <returns></returns>
        public Note GetNote(string id);

        /// <summary>
        /// Получить список всех заметок
        /// </summary>
        /// <returns>Cписок всех заметок</returns>
        public IEnumerable<Note> GetAllNotes();

        /// <summary>
        /// Получить список недавних заметок
        /// </summary>
        /// <returns>Cписок недавних заметок</returns>
        public IEnumerable<Note> GetRecentNotes();

        /// <summary>
        /// // Получить список старых заметок
        /// </summary>
        /// <returns>Cписок старых заметок</returns>
        public IEnumerable<Note> GetOldNotes();

        /// <summary>
        /// Сохранить заметку
        /// </summary>
        /// <param name="noteToSave">Сохраняемая заметка</param>
        public void SaveNote(Note noteToSave);

        /// <summary>
        /// Найти заметки
        /// </summary>
        /// <param name="valueToSearch">Ключевое значение для поиска</param>
        /// <returns>Cписок найденных заметок</returns>
        public IEnumerable<Note> SearchNotes(string valueToSearch);

        /// <summary>
        /// Удалить заметку
        /// </summary>
        /// <param name="id">ID заметки</param>
        public void DeleteNote(string id);

        /// <summary>
        /// Получить бланк/пустую заметку
        /// </summary>
        /// <returns>Пустая заметка</returns>
        public Note GetEmptyNote();
    }
}
