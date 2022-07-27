using NotesApp.Models.Note;
using NotesApp.ViewModels;
using System.Collections.Generic;

namespace NotesApp.Extensions
{
    public static class IEnumerableExtension
    {
        public static IEnumerable<NoteViewModel> ToViewModels(this IEnumerable<INote> notes)
        {
            var result = new List<NoteViewModel>();

            foreach (var note in notes)
            {
                result.Add(new NoteViewModel(note));
            }

            return result;
        }
    }
}
