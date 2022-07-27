using NotesApp.Commands;
using NotesApp.Data;
using NotesApp.Extensions;
using System.Collections.ObjectModel;
using System.Linq;

namespace NotesApp.ViewModels
{
    public class NotesViewModel
    {
        #region Поля
        private readonly CommandBase _deleteCommand;
        private readonly CommandBase _refreshCommand;
        private readonly CommandBase _searchCommand;

        private ObservableCollection<NoteViewModel> _notes;
        #endregion

        #region Свойства
        public ObservableCollection<NoteViewModel> Notes
        {
            get
            {
                return _notes;
            }
            private set
            {
                _notes = value;
            }
        }

        #region Комманды
        public CommandBase DeleteCommand
        {
            get
            {
                return _deleteCommand;
            }
        }

        public CommandBase RefreshCommand
        {
            get => _refreshCommand;
        }

        public CommandBase SearchCommand
        {
            get => _searchCommand;
        }
        #endregion

        #endregion

        public NotesViewModel()
        {
            _deleteCommand = new RelayCommand(execute: DeleteCommand_Execute);
            _refreshCommand = new RelayCommand(execute: RefreshCommand_Execute);
            _searchCommand = new RelayCommand(execute: SearchCommand_Execute);
            _notes = new ObservableCollection<NoteViewModel>(DataSourceContainer.GetInstance().GetAllNotes().ToViewModels());
        }

        #region Методы для Commands

        private void RefreshCommand_Execute(object parameter)
        {
            _notes.Clear();
            _notes = new ObservableCollection<NoteViewModel>(DataSourceContainer.GetInstance().GetAllNotes().ToViewModels());
        }

        private void DeleteCommand_Execute(object parameter)
        {
            string noteID = parameter as string;

            // Физическое удаление
            DataSourceContainer.GetInstance().DeleteNote(noteID);

            // Обновление списка
            RefreshCommand.Execute(null);
        }

        private void SearchCommand_Execute(object parameter)
        {
            string valueToSearch = parameter as string;

            var tempNotes = DataSourceContainer.GetInstance().GetAllNotes();

            // Получение заметок, содержащих в заголовке Title и в контенте Content значение valueToSearch
            var result = tempNotes.Where(note => note.Title.Contains(valueToSearch) || note.Content.Contains(valueToSearch)).ToViewModels();

            _notes = new ObservableCollection<NoteViewModel>(result);
        }

        #endregion 
    }
}
