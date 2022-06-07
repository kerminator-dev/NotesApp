using NotesApp.Commands.MainWindowCommands;
using NotesApp.Data;
using NotesApp.Views;
using System.Collections.Generic;
using System.Windows.Input;
using static NotesApp.Views.CardControl;

namespace NotesApp.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        #region Поля
        private List<CardControl> _cards;
        #endregion

        // События
        public event CardEventHandler OnCardClick;
        public event CardEventHandler OnCardDelete;

        public IReadOnlyList<CardControl> Cards
        {
            get => _cards;
            set
            {
                _cards = (List<CardControl>)value;

                SubsribeToCardEvents();
                OnPropertyChanged(nameof(Cards));
            }
        }

        /// <summary>
        /// Удалить заметку
        /// </summary>
        /// <param name="noteID"></param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Interoperability", "CA1416:Проверка совместимости платформы", Justification = "<Ожидание>")]
        public void DeleteCard(string noteID)
        {
            // Удаление в БД
            DataSourceContainer.GetInstance().DeleteNote(noteID);

            // UpdateCards(NotesGroup.All);

            HandyControl.Controls.Notification.Show
            (
                content: new NotificationControl
                (
                    new Models.Notification
                    (
                        title: $"Заметка успешно удалена"
                    )
                )
            );
        }

        public readonly ICommand GetAllNotesCommand;
        public readonly ICommand GetRecentNotesCommand;
        public readonly ICommand GetOldNotesCommand;
        public readonly ICommand SearchNotesCommand;

        public MainWindowViewModel()
        {
            _cards = new List<CardControl>();

            GetAllNotesCommand = new GetAllNotesCommand(this);
            GetRecentNotesCommand = new GetRecentNotesCommand(this);
            GetOldNotesCommand = new GetOldNotesCommand(this);
            SearchNotesCommand = new SearchNotesCommand(this);
        }

        /// <summary>
        /// Подписаться на события для всех карточек
        /// </summary>
        private void SubsribeToCardEvents()
        {
            foreach (var card in Cards)
            {
                card.OnCardClick += OnCardClick;
                card.OnDeleteButtonClick += OnCardDelete;
            }
        }
    }
}
