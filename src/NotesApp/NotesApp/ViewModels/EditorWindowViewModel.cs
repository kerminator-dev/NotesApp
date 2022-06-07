using NotesApp.Data;
using NotesApp.Models.Note;
using System;

namespace NotesApp.ViewModels
{
    public class EditorWindowViewModel : ViewModelBase
    {
        #region Поля

        /// <summary>
        /// Сохранена ли заметка
        /// </summary>
        private bool _noteSaved = true;

        /// <summary>
        /// Заметка
        /// </summary>
        private readonly INote _note;

        /// <summary>
        /// Сообщение об ошибке
        /// </summary>
        private string _errorMessage = string.Empty;

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
                _note.ID = value;
                OnPropertyChanged(nameof(Id));
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
                _note.Title = value;

                OnPropertyChanged(nameof(Title));
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
                _note.Content = value;
                OnPropertyChanged(nameof(Content));
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
                _note.Created = value;
                OnPropertyChanged(nameof(Created));
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
                _noteSaved = value;
                OnPropertyChanged(nameof(NoteSaved));
            }
        }

        public bool HasError => string.IsNullOrEmpty(_errorMessage);
        
        /// <summary>
        /// Сообщение об ошибке
        /// </summary>
        public string ErrorMessage
        {
            get => _errorMessage;
            private set
            {
                _errorMessage = value;

                OnPropertyChanged(nameof(ErrorMessage));
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
