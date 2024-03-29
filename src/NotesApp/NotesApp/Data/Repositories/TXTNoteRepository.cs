﻿using NotesApp.Data.Repositories;
using NotesApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NotesApp.Data.Repositories
{
    internal class TXTNoteRepository : INoteRepository
    {
        #region Поля

        /// <summary>
        /// Формат файлов
        /// </summary>
        private const string FILE_FORMAT = ".txt";

        /// <summary>
        /// Паттерн для фильтрации файлов в папке
        /// </summary>
        private const string FILE_SEARCH_PATTERN = "*" + FILE_FORMAT;

        /// <summary>
        /// Директория заметок/текстовых файлов
        /// </summary>
        private readonly string _fileDirectory = "MyNotes";

        #endregion

        #region Методы

        public void DeleteNote(string filePath)
        {
            if (File.Exists(filePath))
                File.Delete(filePath);
        }

        /// <summary>
        /// Получить все заметки
        /// </summary>
        /// <returns>Коллекция заметок</returns>
        public IEnumerable<Note> GetAllNotes()
        {
            if (!Directory.Exists(_fileDirectory))
                return new List<Note>();

            var notes = new List<Note>();

            foreach (var filePath in Directory.GetFiles(_fileDirectory, FILE_SEARCH_PATTERN))
            {
                var note = new Note
                (
                    id: filePath,
                    title: Path.GetFileName(filePath).Replace(FILE_FORMAT, ""),
                    content: File.ReadAllText(filePath),
                    created: File.GetCreationTime(filePath)
                );

                notes.Add(note);
            }

            return notes;
        }

        /// <summary>
        /// Получить пустую заметку
        /// </summary>
        /// <returns>Пустая заметка</returns>
        public Note GetEmptyNote()
        {
            return new Note("-1", "Заголовок", "Основной текст", DateTime.Now);
        }

        /// <summary>
        /// Получить заметку
        /// </summary>
        /// <param name="filePath">Путь к файлу</param>
        /// <returns>Заметка</returns>
        public Note GetNote(string filePath)
        {
            if (!File.Exists(filePath))
                return this.GetEmptyNote();

            return new Note
            (
                id: filePath,
                title: Path.GetFileName(filePath).Replace(FILE_FORMAT, ""),
                content: File.ReadAllText(filePath),
                created: File.GetCreationTime(filePath)
            );
        }

        /// <summary>
        /// Получить старые заметки
        /// </summary>
        /// <returns>Коллекция заметок</returns>
        public IEnumerable<Note> GetOldNotes()
        {
            if (!Directory.Exists(_fileDirectory))
                return new List<Note>();

            var dateTimeRangeStart = DateTime.Now.AddDays(-7);
            var notes = new List<Note>();

            foreach (var filePath in Directory.EnumerateFiles(_fileDirectory, FILE_SEARCH_PATTERN).Where(i => File.GetCreationTime(i) <= dateTimeRangeStart))
            {
                var note = new Note
                (
                    id: filePath,
                    title: Path.GetFileName(filePath).Replace(FILE_FORMAT, ""),
                    content: File.ReadAllText(filePath),
                    created: File.GetCreationTime(filePath)
                );

                notes.Add(note);
            }

            return notes;
        }

        /// <summary>
        /// Получить недавние заметки (за последние 7 дней)
        /// </summary>
        /// <returns>Коллекция заметок</returns>
        public IEnumerable<Note> GetRecentNotes()
        {
            if (!Directory.Exists(_fileDirectory))
                return new List<Note>();

            var dateTimeRangeStart = DateTime.Now.AddDays(-7);
            var notes = new List<Note>();
            var filePathCreationDate = new Dictionary<string, DateTime>();

            foreach (var filePath in Directory.EnumerateFiles(_fileDirectory, FILE_SEARCH_PATTERN))
            {
                filePathCreationDate.Add(filePath, File.GetCreationTime(filePath));
            }

            foreach (var file in filePathCreationDate.Where(i => i.Value >= dateTimeRangeStart))
            {
                var note = new Note
                (
                    id: file.Key,
                    title: Path.GetFileName(file.Key).Replace(FILE_FORMAT, ""),
                    content: File.ReadAllText(file.Key),
                    created: file.Value
                );

                notes.Add(note);
            }

            return notes;
        }

        /// <summary>
        /// Сохранить заметку
        /// </summary>
        /// <param name="noteToSave">Заметка</param>
        public void SaveNote(Note noteToSave)
        {
            string filePath = noteToSave.ID;
            string oldTitle = Path.GetFileName(filePath).Replace(FILE_FORMAT, "");
            string newTitle = noteToSave.Title;

            // Если старое название файла (Title) отличается от нового названия (Title), то старый файл удаляется
            if (oldTitle != newTitle)
            {

                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }

                // Название нового файла
                filePath = Path.Combine(_fileDirectory, newTitle + FILE_FORMAT);
            }

            // Если файла с указанным новым названием не существует, то он создаётся
            if (!File.Exists(filePath))
            {
                try
                {
                    using (FileStream sw = File.Create(filePath)) { }
                }
                catch (System.IO.IOException)
                {
                    filePath = Path.Combine(_fileDirectory, oldTitle + FILE_FORMAT);
                }
            }

            // Запись в строк в файл
            if (File.Exists(filePath))
            {
                using (var fs = new StreamWriter(filePath))
                {
                    fs.Write(noteToSave.Content);
                }
            }
        }

        /// <summary>
        /// Найти заметки
        /// </summary>
        /// <param name="valueToSearch">Ключевое значение для поиска</param>
        /// <returns>Cписок найденных заметок</returns>
        public IEnumerable<Note> SearchNotes(string valueToSearch)
        {
            if (!Directory.Exists(_fileDirectory))
                return new List<Note>();

            var notes = new List<Note>();

            foreach (var filePath in Directory.EnumerateFiles(_fileDirectory, FILE_SEARCH_PATTERN)
                    .Where(i => File.ReadAllText(i).Contains(valueToSearch) || i.Contains(valueToSearch)))
            {
                var note = new Note
                (
                    id: filePath,
                    title: Path.GetFileName(filePath).Replace(FILE_FORMAT, ""),
                    content: File.ReadAllText(filePath),
                    created: File.GetCreationTime(filePath)
                );

                notes.Add(note);
            }

            return notes;
        }

        #endregion 
    }
}
