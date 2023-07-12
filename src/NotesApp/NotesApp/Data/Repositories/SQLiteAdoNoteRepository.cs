using Microsoft.Data.Sqlite;
using NotesApp.Data.Repositories;
using NotesApp.Extensions;
using NotesApp.Models;
using System;
using System.Collections.Generic;

namespace NotesApp.Data.Repositories
{
    /// <summary>
    /// Класс для работы с БД SQLITE средствами ADO.NET
    /// </summary>
    internal class SQLiteAdoNoteRepository : IDisposable, INoteRepository
    {
        #region Поля

        /// <summary>
        /// Строка подключения к БД SQLite
        /// </summary>
        private static string ConnectionString { get; } = @"Data Source=NotesDB;";

        private readonly SqliteConnection _connection;

        #endregion

        public SQLiteAdoNoteRepository()
        {
            _connection = new SqliteConnection(ConnectionString);
        }

        #region Методы

        /// <summary>
        /// Получить список всех заметок пользователя
        /// </summary>
        /// <returns>Список заметок</returns>
        public IEnumerable<Note> GetAllNotes()
        {
            var notes = new List<Note>();
            Note tempNote;

            using (_connection)
            {
                _connection.Open();

                string sql = $"SELECT note_id, title, content, created FROM notes ORDER BY created DESC";

                try
                {
                    using (SqliteCommand command = new SqliteCommand(sql, _connection))
                    {
                        using (SqliteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows) // если есть данные
                            {
                                while (reader.Read())   // построчно считываем данные
                                {
                                    tempNote = new Note
                                    (
                                        id: Convert.ToString(reader.GetValue(0)),
                                        title: Convert.ToString(reader.GetValue(1)),
                                        content: Convert.ToString(reader.GetValue(2)),
                                        created: Convert.ToDateTime(reader.GetValue(3))
                                    );

                                    notes.Add(tempNote);
                                }
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    return (IList<Note>)notes;
                }
                finally
                {
                    _connection.Close();
                }
            }

            return (IList<Note>)notes;
        }

        /// <summary>
        /// Получить заметку
        /// </summary>
        /// <param name="noteID">ID заметки</param>
        /// <returns></returns>
        public Note GetNote(string noteID)
        {
            var note = new Note("-1", "Заголовок", "Основной текст", DateTime.Now);

            using (_connection)
            {
                _connection.Open();

                string sql = $"SELECT note_id, title, content, created FROM notes WHERE note_id = {noteID}";

                try
                {
                    using (SqliteCommand command = new SqliteCommand(sql, _connection))
                    {
                        using (SqliteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows) // если есть данные
                            {
                                while (reader.Read())   // построчно считываем данные
                                {
                                    note = new Note
                                    (
                                        id: Convert.ToString(reader.GetValue(0)),
                                        title: Convert.ToString(reader.GetValue(1)),
                                        content: Convert.ToString(reader.GetValue(2)),
                                        created: Convert.ToDateTime(reader.GetValue(3))
                                    );
                                }
                            }
                        }
                    }
                }
                finally
                {
                    _connection.Close();
                }
            }

            return note;
        }

        /// <summary>
        /// Удалить заметку
        /// </summary>
        /// <param name="noteID">ID заметки</param>
        public void DeleteNote(string noteID)
        {
            using (_connection)
            {
                _connection.Open();

                string sql = $"DELETE FROM notes WHERE note_id = {noteID}";

                try
                {
                    using (SqliteCommand command = new SqliteCommand(sql, _connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                finally
                {
                    _connection.Close();
                }
            }
        }

        /// <summary>
        /// Получить список последний заметок пользователя за неделю
        /// </summary>
        /// <returns>Список заметок</returns>
        public IEnumerable<Note> GetRecentNotes()
        {
            var notes = new List<Note>();
            Note tempNote;

            using (_connection)
            {
                _connection.Open();

                string sql = $"SELECT note_id, title, content, created FROM notes WHERE created >= DATETIME('now', '-7 day')";

                try
                {
                    using (SqliteCommand command = new SqliteCommand(sql, _connection))
                    {
                        using (SqliteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows) // если есть данные
                            {
                                while (reader.Read())   // построчно считываем данные
                                {
                                    tempNote = new Note
                                    (
                                        id: Convert.ToString(reader.GetValue(0)),
                                        title: Convert.ToString(reader.GetValue(1)),
                                        content: Convert.ToString(reader.GetValue(2)),
                                        created: Convert.ToDateTime(reader.GetValue(3))
                                    );

                                    notes.Add(tempNote);
                                }
                            }
                        }
                    }
                }
                finally
                {
                    _connection.Close();
                }
            }

            return (IList<Note>)notes;
        }

        /// <summary>
        /// Получить список последний заметок пользователя
        /// </summary>
        /// <returns>Список заметок</returns>
        public IEnumerable<Note> GetOldNotes()
        {
            var notes = new List<Note>();
            Note tempNote;

            using (_connection)
            {
                _connection.Open();

                string sql = $"SELECT note_id, title, content, created FROM notes WHERE created < DATETIME('now', '-7 day')";

                try
                {
                    using (SqliteCommand command = new SqliteCommand(sql, _connection))
                    {
                        using (SqliteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows) // если есть данные
                            {
                                while (reader.Read())   // построчно считываем данные
                                {
                                    tempNote = new Note
                                    (
                                        id: Convert.ToString(reader.GetValue(0)),
                                        title: Convert.ToString(reader.GetValue(1)),
                                        content: Convert.ToString(reader.GetValue(2)),
                                        created: Convert.ToDateTime(reader.GetValue(3))
                                    );

                                    notes.Add(tempNote);
                                }
                            }
                        }
                    }
                }
                finally
                {
                    _connection.Close();
                }
            }

            return (IList<Note>)notes;
        }

        /// <summary>
        /// Сохранить заметку
        /// </summary>
        /// <param name="note">Заметка</param>
        public void SaveNote(Note note)
        {
            // Если id заметки не известен, то заметка добавляется в таблицу (INSERT)
            // Если id заметки известен, то заметка обновляется (UPDATE)
            if (note.ID == "-1")
            {
                CreateNote(note);
            }
            else
            {
                UpdateNote(note);
            }
        }

        /// <summary>
        /// Обновить даннные о заметке в бд
        /// </summary>
        /// <param name="note">Заметка</param>
        private void UpdateNote(Note note)
        {
            using (_connection)
            {
                _connection.Open();

                string sql = $"UPDATE notes SET title = '{note.Title}', content = '{note.Content}' WHERE note_id = {note.ID}";

                try
                {
                    using (SqliteCommand command = new SqliteCommand(sql, _connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                finally
                {
                    _connection.Close();
                }
            }
        }

        /// <summary>
        /// Добавить заметку в БД
        /// </summary>
        /// <param name="note">Заметка</param>
        private void CreateNote(Note note)
        {
            using (_connection)
            {
                _connection.Open();

                string sql = $"INSERT INTO notes (title, content, created) VALUES ('{note.Title}', '{note.Content}', '{note.Created.ToSQLiteDateTimeString()}')";

                try
                {
                    using (SqliteCommand command = new SqliteCommand(sql, _connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception)
                {
                    note.ID = "-1";
                }
                finally
                {
                    _connection.Close();
                }
            }

            // Обновление ID 
            note.ID = GetLastInsertedNoteIdAsync().ToString();
        }

        /// <summary>
        /// Получить ID последней добавленной заметки
        /// </summary>
        /// <returns>ID последней добавленной заметки</returns>
        private int GetLastInsertedNoteIdAsync()
        {
            using (var connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();

                string sql = $"SELECT last_insert_rowid()";

                try
                {
                    using (SqliteCommand command = new SqliteCommand(sql, connection))
                    {
                        using (SqliteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows) // если есть данные
                            {
                                while (reader.Read())   // построчно считываем данные
                                {
                                    return reader.GetFieldValue<int>(0);
                                }

                            }
                        }
                    }
                }
                finally
                {
                    _connection.Close();
                }
            }

            return -1;
        }

        /// <summary>
        /// Существует ли заметка
        /// </summary>
        /// <param name="noteID">ID заметки</param>
        /// <returns></returns>
        public bool NoteContains(int noteID)
        {
            using (_connection)
            {
                _connection.Open();

                string sql = $"SELECT SINGLE note_id, title, content, created FROM notes WHERE note_id = {noteID}";

                try
                {
                    using (SqliteCommand command = new SqliteCommand(sql, _connection))
                    {
                        using (SqliteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows) // если есть данные
                            {
                                return true;
                            }
                        }
                    }
                }
                finally
                {
                    _connection.Close();
                }
            }

            return false;
        }

        /// <summary>
        /// Поиск заметок
        /// SQLite не ладит с кириллицей - функция LOWER для преобразования строк в нижний регист не работает
        /// Т. е. запрос SELECT ... FROM ... WHERE LOWER(title) LIKE LOWER('%value%') .... работать не будет
        /// Поэтому вместо поисковых обращений к БД получаю список всех заметок пользователя
        /// И фильтрую их уже внутри программы
        /// </summary>
        /// <param name="searchValue">Значение, которое нужно найти</param>
        /// <returns>Список заметок</returns>
        public IEnumerable<Note> SearchNotes(string searchValue)
        {
            var notes = new List<Note>((IEnumerable<Note>)this.GetAllNotes());
            return (IList<Note>)notes.FindAll(i => i.Content.Contains(searchValue, StringComparison.OrdinalIgnoreCase) || i.Title.Contains(searchValue, StringComparison.OrdinalIgnoreCase));
        }

        /// <summary>
        /// Освободить ресурсы
        /// </summary>
        public void Dispose()
        {
            _connection.Dispose();
        }

        /// <summary>
        /// Получить пустую заметку
        /// </summary>
        /// <returns>Пустая заметка</returns>
        public Note GetEmptyNote()
        {
            return new Note("-1", "Заголовок", "Основной текст", DateTime.Now);
        }

        #endregion
    }
}
