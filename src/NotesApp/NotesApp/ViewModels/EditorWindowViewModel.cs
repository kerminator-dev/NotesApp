using HandyControl.Controls;
using HandyControl.Data;
using NotesApp.Commands;
using NotesApp.Data;
using NotesApp.Models;
using NotesApp.Views;
using System;
using System.Windows.Input;

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
        private readonly Note _note;

        /// <summary>
        /// Сообщение об ошибке
        /// </summary>
        private string _errorMessage = string.Empty;

        private CommandBase _saveCommand;
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
            set
            {
                _errorMessage = value;

                OnPropertyChanged(nameof(ErrorMessage));
            }
        }

        /// <summary>
        /// Комманда - сохранить заметку
        /// </summary>
        public CommandBase SaveCommand
        {
            get
            {
                return _saveCommand;
            }
            
        }

        #endregion

        public EditorWindowViewModel()
        {
            _saveCommand = new RelayCommand
            (
                execute: SaveCommand_Execute,
                canExecute: SaveCommand_CanExecute
            );
            // _note = DataSourceContainer.GetInstance().GetEmptyNote();
        }

        public EditorWindowViewModel(string noteID)
        {
            _saveCommand = new RelayCommand
            (
                execute: SaveCommand_Execute,
                canExecute: SaveCommand_CanExecute
            );
            // _note = DataSourceContainer.GetInstance().GetNote(noteID);
        }

        #region Методы для ICommand SaveCommand

        private void SaveCommand_Execute(object parameter)
        {
            // DataSourceContainer.GetInstance().SaveNote(this._note);
            NoteSaved = true;
            HandyControl.Controls.Notification.Show(new NotificationControl(new Models.Notification("Заметка успешно сохранена")), ShowAnimation.None);
            SaveCommand.OnCanExecuteChanged();
        }

        private bool SaveCommand_CanExecute(object parameter)
        {
            if (Title == String.Empty || Content == String.Empty)
            {
                ErrorMessage = "Заголовок и основной текст не должны быть пустыми!";
                return false;
            }

            return true;
        }

        #endregion
    }
}
