using NotesApp.ViewModels;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace NotesApp.Views
{
    /// <summary>
    /// Логика взаимодействия для CardControl.xaml
    /// </summary>
    public partial class CardControl : UserControl
    {
        public string ID => _viewModel.ID;
        private readonly NoteViewModel _viewModel;

        public delegate void CardEventHandler(string clickedNoteId, EventArgs e);

        // Событие при удалении карточки (для обновления основной формы с карточками) 
        public event CardEventHandler? OnDeleteButtonClick;

        // Соыбтие при нажатии на карточку (для открытия окна редактирования заметки из главной формы)
        public event CardEventHandler? OnCardClick;

        public CardControl(NoteViewModel cardControlViewModel, TimeSpan animationBeginTime)
        {
            InitializeComponent();

            _viewModel = cardControlViewModel;
            DataContext = _viewModel;
            OpacityAnimation.BeginTime = animationBeginTime;
        }

        private void Control_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            ContentTextBlock.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            CreatedTextBlock.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            DeleteButton.Visibility = Visibility.Visible;
        }

        private void Control_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            ContentTextBlock.Foreground = new SolidColorBrush(Color.FromRgb(140, 140, 140));
            CreatedTextBlock.Foreground = new SolidColorBrush(Color.FromRgb(190, 190, 191));
            DeleteButton.Visibility = Visibility.Hidden;
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            OnDeleteButtonClick?.Invoke(_viewModel.ID, e);
        }

        private void Control_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            OnCardClick?.Invoke(_viewModel.ID, e);
        }
    }
}
