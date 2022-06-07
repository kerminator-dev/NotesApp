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
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Задержка перед появлением карт
        /// </summary>
        private const int CARDS_FLOW_START_DELAY = 1900;
        private readonly MainWindowViewModel _viewModel;
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

        public MainWindow(MainWindowViewModel viewModel)
        {
            InitializeComponent();
            _editorWindow = new EditorWindow();
            _viewModel = viewModel;
            _viewModel.OnCardClick += Card_OnClick;
            _viewModel.OnCardDelete += Card_OnDelete;
        }

        private void EditorWindow_Closing(object? sender, CancelEventArgs e)
        {
            ScrollViewer?.ScrollToTop();
        }

        private void SearchTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            _viewModel.SearchNotesCommand.Execute(SearchTextBox.Text);
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
        /// Событие для CardControl для открытия окна редактирования
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
            var timer = new Timer(CARDS_FLOW_START_DELAY);
            timer.Elapsed += ShowCards;
            timer.AutoReset = false;
            timer.Start();
        }

        private void ShowCards(object? sender, ElapsedEventArgs e)
        {
            Dispatcher.BeginInvoke(new Action(() =>
            {
                _viewModel?.GetAllNotesCommand.Execute(null);
            }));

            (sender as Timer)?.Dispose();
        }

        private void AllRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            _viewModel?.GetAllNotesCommand.Execute(null);
        }

        private void RecentRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            _viewModel?.GetRecentNotesCommand.Execute(null);
        }

        private void OldRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            _viewModel?.GetOldNotesCommand.Execute(null);
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            // Сохранение настроек - позиции окна
            Properties.Settings.Default.Save();
        }
    }
}