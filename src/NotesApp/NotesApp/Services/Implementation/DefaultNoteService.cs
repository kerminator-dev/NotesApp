using NotesApp.Data.Repositories;
using NotesApp.Models;
using NotesApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NotesApp.Services.Implementation
{
    class DefaultNoteService : INoteService
    {
        private readonly INoteRepository _noteRepository;

        public event Action<Note>? OnNoteCreated;
        public event Action<Note>? OnNoteUpdated;
        public event Action<string>? OnNoteDeleted;

        public DefaultNoteService(INoteRepository noteRepository)
        {
            _noteRepository = noteRepository;
        }

        public Task<bool> Create(Note note)
        {
            _noteRepository.SaveNote(note);

            OnNoteCreated?.Invoke(note);

            // Затычка
            return Task.FromResult(true);
        }

        public Task<bool> Delete(string id)
        {
            _noteRepository.DeleteNote(id);

            OnNoteDeleted?.Invoke(id);

            // Затычка
            return Task.FromResult(true);
        }

        public Task<Note> Get(string id)
        {
            return Task.FromResult(_noteRepository.GetNote(id));
        }

        public Task<IEnumerable<Note>> GetAll()
        {
            return Task.FromResult(_noteRepository.GetAllNotes());
        }

        public Task<bool> Update(Note note)
        {
            _noteRepository.SaveNote(note);

            OnNoteUpdated?.Invoke(note);

            // Затычка
            return Task.FromResult(true);
        }
    }
}
