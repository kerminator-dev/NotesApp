using NotesApp.Data;
using NotesApp.Extensions;
using NotesApp.Models.Note;
using NotesApp.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace NotesApp.Commands.MainWindowCommands
{
    public class SearchNotesCommand : CommandBase
    {
        private readonly MainWindowViewModel _viewModel;

        public SearchNotesCommand(MainWindowViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public override void Execute(object? parameter)
        {
            var searchValue = parameter as string;
            List<INote> notes = DataSourceContainer.GetInstance().SearchNotes(searchValue).ToList();
            _viewModel.Cards = notes.ToCardsList();
        }
    }
}
