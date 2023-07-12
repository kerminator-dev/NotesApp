using NotesApp.Models;
using NotesApp.Services.Interfaces.Operations;
using System;

namespace NotesApp.Services.Interfaces
{
    /// <summary>
    /// Вообще, очень спорный подход к наследованию интерфейсов
    /// 
    /// По большей части это нужно для инкапсуляции ненужных методов.
    /// Чтобы, например, команда DeleteNoteCommand не имела возможности 
    /// Вызывать методы Create, Update и т. д. и чтобы использовала только
    /// Интерфейс IDeleteOperation
    /// </summary>
    public interface INoteService : 
        ICreateOperation<Note, bool>, 
        IDeleteOperation<string, bool>, 
        IUpdateOperation<Note, bool>,
        IGetOperation<string, Note>
    {
        event Action<Note> OnNoteCreated;
        event Action<Note> OnNoteUpdated;
        event Action<string> OnNoteDeleted;
    }
}
