using System;

namespace NotesApp.Commands
{
    class CloseAppCommand : CommandBase
    {
        public override void Execute(object? parameter)
        {
            Environment.Exit(0);
        }
    }
}
