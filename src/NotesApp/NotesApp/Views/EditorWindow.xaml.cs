using HandyControl.Controls;
using HandyControl.Data;
using NotesApp.ViewModels;
using System;
using System.Timers;
using System.Windows;
using System.Windows.Input;

namespace NotesApp.Views
{
    /// <summary>
    /// Логика взаимодействия для EditorWindow.xaml
    /// </summary>
    public partial class EditorWindow : System.Windows.Window
    {
        // Таймер для обновления размера текста
        // При изменении размера текста с большим количеством символов в реальном времени происходит задержка
        // Если пользователь не трогает слайдер n миллисекунд, то происходит обновление размеров текста
        private readonly Timer FontSliderTimer;

        private readonly EditorWindowViewModel _viewModel;

        #region Конструкторы

        /// <summary>
        /// Редактор заметок - создание новой заметки
        /// </summary>
        public EditorWindow()
        {
            InitializeComponent();

            _viewModel = new EditorWindowViewModel();
            this.DataContext = _viewModel;

            FontSliderTimer = new Timer();
            FontSliderTimer.Interval = 500;
            FontSliderTimer.Elapsed += FontSliderTimer_Elapsed;
            FontSliderTimer.AutoReset = false;

            this.Top = Properties.Settings.Default.EditorWindowTop;
            this.Left = Properties.Settings.Default.EditorWindowLeft;
        }

        /// <summary>
        /// Редактор заметок - редактирование существующей заметки
        /// </summary>
        /// <param name="note">Заметка</param>
        public EditorWindow(string noteID) : this()
        {
            _viewModel = new EditorWindowViewModel
            (
                noteID: noteID
            );

            this.DataContext = _viewModel;
        }

        #endregion

        #region Событмя

        /// <summary>
        /// Перетаскивание окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                base.OnMouseLeftButtonDown(e);
                DragMove();
            }
        }

        /// <summary>
        /// При попытке выхода
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (_viewModel.NoteSaved == true)
            {
                this.Close();
                return;
            }

            if (TitleTextBox.Text == String.Empty && ContentTextBox.Text == String.Empty)
            {
                this.Close();
                return;
            }

            if (System.Windows.MessageBox.Show("Выйти без сохранения?", "Выход", MessageBoxButton.YesNoCancel) == MessageBoxResult.Yes)
            {
                this.Close();
                return;
            }
        }

        private void FontSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (FontSliderTimer == null)
                return;

            FontSliderTimer.Stop();
            FontSliderTimer.Start();
        }

        /// <summary>
        /// При изменения значения слайдера, после задержки 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FontSliderTimer_Elapsed(object? sender, ElapsedEventArgs? e)
        {
            Dispatcher.Invoke(() =>
            {
                TitleTextBox.FontSize = FontSlider.Value + 8;
                DateTextBlock.FontSize = FontSlider.Value;
                ContentTextBox.FontSize = FontSlider.Value + 4;
            });
        }

        /// <summary>
        /// При двойном нажатии на Header - расширение окна или уменьшение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Header_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
            }
            else
            {
                this.WindowState = WindowState.Maximized;
            }
        }

        #endregion

        private void FontSlider_Loaded(object sender, RoutedEventArgs e)
        {
            FontSliderTimer_Elapsed(sender, default);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void SaveButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (_viewModel.NoteSaved == true)
                return;

            if (TitleTextBox.Text == String.Empty || ContentTextBox.Text == String.Empty)
            {
                System.Windows.MessageBox.Show("Заголовок и основной текст не должны быть пустыми!");
                return;
            }

            _viewModel.SaveChanges();
            Notification.Show(new NotificationControl(new Models.Notification("Заметка успешно сохранена")), ShowAnimation.None);
        }
    }
}
