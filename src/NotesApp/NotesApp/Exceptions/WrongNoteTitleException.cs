using System;

namespace NotesApp.Exceptions
{
    internal class WrongNoteTitleException : Exception
    {
        public WrongNoteTitleException(string message = "Заголовок содержит запрещённые символы!") : base(message) { }
    }
}
