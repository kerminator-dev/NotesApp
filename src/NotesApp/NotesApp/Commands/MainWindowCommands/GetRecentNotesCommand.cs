using NotesApp.Data;
using NotesApp.Extensions;
using NotesApp.Models.Note;
using NotesApp.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace NotesApp.Commands.MainWindowCommands
{
    public class GetRecentNotesCommand : CommandBase
    {
        private readonly MainWindowViewModel _viewModel;

        public GetRecentNotesCommand(MainWindowViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public override void Execute(object? parameter)
        {
            List<INote> notes = DataSourceContainer.GetInstance().GetRecentNotes().ToList();
            _viewModel.Cards = notes.ToCardsList();
        }
    }
}
