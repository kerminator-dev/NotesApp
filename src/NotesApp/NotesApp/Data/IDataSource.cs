using NotesApp.Models.Note;
using System.Collections.Generic;

namespace NotesApp.Data
{
    /// <summary>
    /// Интерфейс, описывающий контракт для работы с разными иточниками данных заметок
    /// </summary>
    public interface IDataSource
    {
        /// <summary>
        /// Получить заметку по ID
        /// </summary>
        /// <param name="id">ID заметки</param>
        /// <returns></returns>
        public INote GetNote(string id);

        /// <summary>
        /// Получить список всех заметок
        /// </summary>
        /// <returns>Cписок всех заметок</returns>
        public IEnumerable<INote> GetAllNotes();

        /// <summary>
        /// Получить список недавних заметок
        /// </summary>
        /// <returns>Cписок недавних заметок</returns>
        public IEnumerable<INote> GetRecentNotes();

        /// <summary>
        /// // Получить список старых заметок
        /// </summary>
        /// <returns>Cписок старых заметок</returns>
        public IEnumerable<INote> GetOldNotes();

        /// <summary>
        /// Сохранить заметку
        /// </summary>
        /// <param name="noteToSave">Сохраняемая заметка</param>
        public void SaveNote(INote noteToSave);

        /// <summary>
        /// Найти заметки
        /// </summary>
        /// <param name="valueToSearch">Ключевое значение для поиска</param>
        /// <returns>Cписок найденных заметок</returns>
        public IEnumerable<INote> SearchNotes(string valueToSearch);

        /// <summary>
        /// Удалить заметку
        /// </summary>
        /// <param name="id">ID заметки</param>
        public void DeleteNote(string id);

        /// <summary>
        /// Получить бланк/пустую заметку
        /// </summary>
        /// <returns>Пустая заметка</returns>
        public INote GetEmptyNote();
    }
}
