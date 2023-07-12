using NotesApp.Services.Interfaces.Operations;
using System;

namespace NotesApp.Commands
{
    class DeleteNoteCommand : CommandBase
    {
        private readonly Action<string> _onNoteDeleted;
        private readonly IDeleteOperation<string, bool> _noteService;

        public DeleteNoteCommand(IDeleteOperation<string, bool> noteService, Action<string> onNoteDeleted)
        {
            _noteService = noteService;
            _onNoteDeleted = onNoteDeleted;
        }

        public override void Execute(object? parameter)
        {
            if (parameter == null)
                throw new ArgumentNullException(nameof(parameter));

            string noteID = parameter as string;
            if (string.IsNullOrWhiteSpace(noteID))
                throw new ArgumentNullException(nameof(parameter));

            // Физическое удаление
            _noteService?.Delete(noteID);

            _onNoteDeleted?.Invoke(noteID);
        }
    }
}
