using NotesApp.Models.Note;
using NotesApp.ViewModels;
using NotesApp.Views;
using System;
using System.Collections.Generic;

namespace NotesApp.Extensions
{
    /// <summary>
    /// Класс c методами-расширениями для класаа List
    /// </summary>
    public static class ListExtension
    {
        /// <summary>
        /// Преобразовать список заметок в список карточек-заметок
        /// </summary>
        /// <param name="notes">Заметки</param>
        /// <param name="animationOffset">Задержка перед началом анимации. Для каждой карточки задержка увеличивается на значение animationOffset</param>
        /// <returns></returns>
        public static IReadOnlyList<CardControl> ToCardsList(this IList<INote> notes, int animationOffset = 250)
        {
            var cards = new List<CardControl>();

            for (int i = 0; i < notes.Count; i++)
            {
                cards.Add
                (
                    new CardControl
                    (
                        cardControlViewModel: new CardControlViewModel(notes[i]),
                        animationBeginTime: new TimeSpan(0, 0, 0, 0, i * animationOffset)
                    )
                );
            }

            return cards;
        }
    }
}
