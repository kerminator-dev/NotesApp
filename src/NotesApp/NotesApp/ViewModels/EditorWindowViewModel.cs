using NotesApp.Data;
using NotesApp.Models.Note;
using System;
using System.ComponentModel;

namespace NotesApp.ViewModels
{
    public class EditorWindowViewModel : INotifyPropertyChanged
    {
        #region Поля

        /// <summary>
        /// Сохранена ли заметка
        /// </summary>
        private bool _noteSaved = false;

        /// <summary>
        /// Заметка
        /// </summary>
        private readonly INote _note;

        #endregion

        #region Свойства

        /// <summary>
        /// ID заметки
        /// </summary>
        public string Id
        {
            get => _note.ID;
            private set
            {
                if (_note.ID == value)
                    return;

                _note.ID = value;
                RaisePropertyChanged(nameof(Id));
                NoteSaved = false;
            }
        }

        /// <summary>
        /// Заголовок заметки
        /// </summary>
        public string Title
        {
            get => _note.Title;
            set
            {
                if (_note.Title == value)
                    return;

                _note.Title = value;
                RaisePropertyChanged(nameof(Title));
                NoteSaved = false;
            }
        }

        /// <summary>
        /// Основной текст заметки
        /// </summary>
        public string Content
        {
            get => _note.Content;
            set
            {
                if (_note.Content == value)
                    return;

                _note.Content = value;
                RaisePropertyChanged(nameof(Content));
                NoteSaved = false;
            }
        }

        /// <summary>
        /// Дата создания заметки
        /// </summary>
        public DateTime Created
        {
            get => _note.Created;
            set
            {
                if (_note.Created == value)
                    return;

                _note.Created = value;
                RaisePropertyChanged(nameof(Created));
                NoteSaved = false;
            }
        }

        /// <summary>
        /// Сохранена ли заметка
        /// </summary>
        public bool NoteSaved
        {
            get => _noteSaved;
            private set
            {
                if (_noteSaved == value)
                    return;

                _noteSaved = value;
                RaisePropertyChanged(nameof(NoteSaved));
            }
        }

        #endregion

        public EditorWindowViewModel()
        {
            _note = DataSourceContainer.GetInstance().GetEmptyNote();
        }

        public EditorWindowViewModel(string noteID)
        {
            _note = DataSourceContainer.GetInstance().GetNote(noteID);
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Сохранить изменения
        /// </summary>
        public void SaveChanges()
        {
            DataSourceContainer.GetInstance().SaveNote(this._note);
            NoteSaved = true;
        }
    }
}
