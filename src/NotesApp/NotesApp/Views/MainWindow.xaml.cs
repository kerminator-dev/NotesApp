using NotesApp.Enums;
using NotesApp.ViewModels;
using System;
using System.ComponentModel;
using System.Timers;
using System.Windows;
using System.Windows.Input;

namespace NotesApp.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : System.Windows.Window
    {
        private EditorWindow _editorWindow;

        private EditorWindow EditorWindow
        {
            get => _editorWindow;
            set
            {
                if (_editorWindow != null && _editorWindow.IsVisible)
                    _editorWindow.Close();

                _editorWindow = value;
                _editorWindow.Closing += EditorWindow_Closing;
            }
        }

        private readonly MainWindowViewModel _viewModel;

        private void EditorWindow_Closing(object? sender, CancelEventArgs e)
        {
            _viewModel.UpdateCards(_selectedGroup);
            ScrollViewer?.ScrollToTop();
        }

        /// <summary>
        /// Выбранная группа
        /// </summary>
        private NotesGroup _selectedGroup;
        private NotesGroup SelectedGroup
        {
            set
            {
                _selectedGroup = value;

                if (_viewModel != null)
                {
                    _viewModel.UpdateCards(_selectedGroup);
                    ScrollViewer?.ScrollToTop();
                }
            }
        }

        public MainWindow()
        {
            InitializeComponent();

            _editorWindow = new EditorWindow();
            _viewModel = new MainWindowViewModel
            (
                onCardClick: Card_OnClick,
                onCardDelete: Card_OnDelete
            );
            this.DataContext = _viewModel;
        }

        private void SearchTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            _viewModel.SearchCards(SearchTextBox.Text);
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                base.OnMouseLeftButtonDown(e);
                DragMove();
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
            Environment.Exit(0);
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            EditorWindow = new EditorWindow();
            EditorWindow.Show();
        }

        private void Card_OnDelete(string clickedNoteId, EventArgs e)
        {
            _viewModel.DeleteCard(clickedNoteId);
        }

        /// <summary>
        /// Событие для CardControl
        /// </summary>
        /// <param name="clickedNoteId">ID нажатой карточки-заметки</param>
        /// <param name="e"></param>
        private void Card_OnClick(string clickedNoteId, EventArgs e)
        {
            EditorWindow = new EditorWindow(clickedNoteId);
            EditorWindow.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Отображение карточек с задержкой (после выполнения анимации окна)
            var timer = new Timer(1900);
            timer.Elapsed += ShowCards;
            timer.AutoReset = false;
            timer.Start();
        }

        private void ShowCards(object? sender, ElapsedEventArgs e)
        {
            Dispatcher.BeginInvoke(new Action(() =>
            {
                _viewModel.UpdateCards(_selectedGroup);
            }));
        }

        private void AllRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            SelectedGroup = NotesGroup.All;
        }

        private void RecentRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            SelectedGroup = NotesGroup.Recent;
        }

        private void OldRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            SelectedGroup = NotesGroup.Old;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            // Сохранение настроек - позиции окна
            Properties.Settings.Default.Save();
        }
    }
}