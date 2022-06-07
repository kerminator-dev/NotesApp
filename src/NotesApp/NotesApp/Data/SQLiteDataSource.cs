﻿using Microsoft.Data.Sqlite;
using NotesApp.Extensions;
using NotesApp.Models.Note;
using System;
using System.Collections.Generic;

namespace NotesApp.Data
{
    /// <summary>
    /// Класс для работы с БД SQLITE
    /// </summary>
    internal class SQLiteDataSource : IDisposable, IDataSource
    {
        #region Поля

        /// <summary>
        /// Строка подключения к БД SQLite
        /// </summary>
        private static string ConnectionString { get; } = @"Data Source=NotesDB;";

        private readonly SqliteConnection _connection;

        #endregion

        public SQLiteDataSource()
        {
            _connection = new SqliteConnection(ConnectionString);
        }

        #region Методы

        /// <summary>
        /// Получить список всех заметок пользователя
        /// </summary>
        /// <returns>Список заметок</returns>
        public IEnumerable<INote> GetAllNotes()
        {
            var notes = new List<SQLiteNote>();
            SQLiteNote tempNote;

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
                                    tempNote = new SQLiteNote
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
                    return (IList<SQLiteNote>)notes;
                }
                finally
                {
                    _connection.Close();
                }
            }

            return (IList<SQLiteNote>)notes;
        }

        /// <summary>
        /// Получить заметку
        /// </summary>
        /// <param name="noteID">ID заметки</param>
        /// <returns></returns>
        public INote GetNote(string noteID)
        {
            var note = new SQLiteNote("-1", "Заголовок", "Основной текст", DateTime.Now);

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
                                    note = new SQLiteNote
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
        public IEnumerable<INote> GetRecentNotes()
        {
            var notes = new List<SQLiteNote>();
            SQLiteNote tempNote;

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
                                    tempNote = new SQLiteNote
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

            return (IList<SQLiteNote>)notes;
        }

        /// <summary>
        /// Получить список последний заметок пользователя
        /// </summary>
        /// <returns>Список заметок</returns>
        public IEnumerable<INote> GetOldNotes()
        {
            var notes = new List<SQLiteNote>();
            SQLiteNote tempNote;

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
                                    tempNote = new SQLiteNote
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

            return (IList<SQLiteNote>)notes;
        }

        /// <summary>
        /// Сохранить заметку
        /// </summary>
        /// <param name="note">Заметка</param>
        public void SaveNote(INote note)
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
        private void UpdateNote(INote note)
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
        private void CreateNote(INote note)
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
        public IEnumerable<INote> SearchNotes(string searchValue)
        {
            var notes = new List<SQLiteNote>((IEnumerable<SQLiteNote>)this.GetAllNotes());
            return (IList<INote>)notes.FindAll(i => i.Content.Contains(searchValue, StringComparison.OrdinalIgnoreCase) || i.Title.Contains(searchValue, StringComparison.OrdinalIgnoreCase));
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
        public INote GetEmptyNote()
        {
            return new SQLiteNote("-1", "Заголовок", "Основной текст", DateTime.Now);
        }

        #endregion
    }
}
