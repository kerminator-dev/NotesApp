using NotesApp.ViewModels;
using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace NotesApp.Views
{
    /// <summary>
    /// По-хорошему бы переписать этот класс
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Задержка перед появлением карт
        /// </summary>
        private readonly MainWindowViewModel _viewModel;
        private EditorWindow _editorWindow;

        private EditorWindow EditorWindow
        {
            get => _editorWindow;
            set
            {
                // Закрытие прошлого окна _editorWindow
                if (_editorWindow != null && _editorWindow.IsVisible)
                    _editorWindow.Close();

                _editorWindow = value;
                _editorWindow.Closing += EditorWindow_Closing;
            }
        }

        public MainWindow(MainWindowViewModel viewModel)
        {
            InitializeComponent();

            _viewModel = viewModel;
            // _viewModel.GetAllNotesCommand.Execute(null);
        }

        private void EditorWindow_Closing(object? sender, CancelEventArgs e)
        {
            ScrollViewer?.ScrollToTop();
        }

        private void SearchTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            //_viewModel.SearchNotesCommand?.Execute(SearchTextBox.Text);
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

        public void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            EditorWindow = new EditorWindow();
            EditorWindow.Show();
        }

        public void Card_OnDelete(string clickedNoteId, EventArgs e)
        {
            // _viewModel.DeleteCard(clickedNoteId);
        }

        /// <summary>
        /// Событие для CardControl для открытия окна редактирования
        /// </summary>
        /// <param name="clickedNoteId">ID нажатой карточки-заметки</param>
        /// <param name="e"></param>
        public void Card_OnClick(string clickedNoteId, EventArgs e)
        {
            EditorWindow = new EditorWindow(clickedNoteId);
            EditorWindow.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }


        private void Window_Closed(object sender, EventArgs e)
        {
            // Сохранение настроек
            Properties.Settings.Default.Save();
        }
    }
}