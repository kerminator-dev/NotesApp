using AutoMapper;
using NotesApp.Commands;
using NotesApp.Services.Interfaces;
using System.Collections.ObjectModel;
using System.Linq;

namespace NotesApp.ViewModels
{
    public class MainWindowViewModel
    {
        private readonly INoteService _noteService;
        private readonly IMapper _mapper;

        private CommandBase _deleteCommand;
        private CommandBase _createCommand;
        private CommandBase _searchCommand;
        private CommandBase _closeWindowCommand;

        private ObservableCollection<NoteViewModel> _notes;

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

        #region Команды
        public CommandBase DeleteCommand
        {
            get => _deleteCommand;
            set => _deleteCommand = value;
        }

        public CommandBase CloseWindowCommand
        {
            get => _closeWindowCommand;
            set => _closeWindowCommand = value;
        }

        public CommandBase CreateCommand
        {
            get => _createCommand;
            set => _createCommand = value;
        }

        public CommandBase SearchCommand
        {
            get => _searchCommand;
            set => _searchCommand = value;
        }
        #endregion

        public MainWindowViewModel(INoteService noteService, IMapper mapper)
        {
            _noteService = noteService;
            _mapper = mapper;

            _deleteCommand = new DeleteNoteCommand(noteService, OnNoteDeleted);
            // _createCommand = new RelayCommand(execute: RefreshCommand_Execute);
            _searchCommand = new RelayCommand(execute: SearchCommand_Execute);
            _closeWindowCommand = new CloseAppCommand();

            _notes = new ObservableCollection<NoteViewModel>();
        }

        public void LoadNotes()
        {
            if (this.Notes == null)
            {
                this.Notes = new ObservableCollection<NoteViewModel>();
            }
            else
            {
                this.Notes.Clear();
            }

            var notes = _noteService.GetAll().Result;

            foreach (var note in notes)
            {
                this.Notes?.Add(_mapper.Map<NoteViewModel>(note));
            }
        }


        #region Методы для Commands

        private void SearchCommand_Execute(object parameter)
        {
            string valueToSearch = parameter as string;

            var tempNotes = _noteService.GetAll().Result;

            // Получение заметок, содержащих в заголовке Title и в контенте Content значение valueToSearch
            var notes = tempNotes.Where(note => note.Title.Contains(valueToSearch) || note.Content.Contains(valueToSearch)).ToList();
            if (!notes.Any())
            {
                return;
            }

            _notes.Clear();

            foreach (var note in notes)
            {
                _notes.Add(_mapper.Map<NoteViewModel>(note));
            }
        }

        private void OnNoteDeleted(string noteId)
        {
            var note = Notes.Where(n => n.ID == noteId).FirstOrDefault();
            if (note == null)
                return;

            Notes.Remove(note);
        }

        #endregion 
    }
}
