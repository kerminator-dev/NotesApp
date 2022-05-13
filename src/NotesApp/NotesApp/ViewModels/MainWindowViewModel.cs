using NotesApp.Data;
using NotesApp.Enums;
using NotesApp.Extensions;
using NotesApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using static NotesApp.Views.CardControl;

namespace NotesApp.ViewModels
{
    internal class MainWindowViewModel : INotifyPropertyChanged
    {
        #region Поля
        private List<CardControl> _cards;

        // События
        private readonly CardEventHandler _onCardClick;
        private readonly CardEventHandler _onCardDelete;

        #endregion

        public IReadOnlyList<CardControl> Cards
        {
            get => _cards;
            private set
            {
                _cards = (List<CardControl>)value;
                SubsribeToCardEvents();
                RaisePropertyChanged(nameof(Cards));
            }
        }

        /// <summary>
        /// Обновить список карточек
        /// </summary>
        /// <param name="groupType">Группа карточек</param>
        public void UpdateCards(NotesGroup groupType)
        {
            switch (groupType)
            {
                case NotesGroup.All:
                    Cards = DataSourceContainer.GetInstance().GetAllNotes().ToList().ToCardsList();
                    break;
                case NotesGroup.Recent:
                    Cards = DataSourceContainer.GetInstance().GetRecentNotes().ToList().ToCardsList();
                    break;
                case NotesGroup.Old:
                    Cards = DataSourceContainer.GetInstance().GetOldNotes().ToList().ToCardsList();
                    break;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="searchValue"></param>
        public void SearchCards(string searchValue)
        {
            if (searchValue == String.Empty)
                UpdateCards(NotesGroup.All);
            else
                Cards = DataSourceContainer.GetInstance().SearchNotes(searchValue).ToList().ToCardsList();
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

            UpdateCards(NotesGroup.All);

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

        public MainWindowViewModel(CardEventHandler onCardClick, CardEventHandler onCardDelete)
        {
            _onCardClick = onCardClick;
            _onCardDelete = onCardDelete;
            _cards = new List<CardControl>();
        }

        /// <summary>
        /// Подписаться на события для всех карточек
        /// </summary>
        private void SubsribeToCardEvents()
        {
            foreach (var card in Cards)
            {
                card.OnCardClick += _onCardClick;
                card.OnDelete += _onCardDelete;
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
