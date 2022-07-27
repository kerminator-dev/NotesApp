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
    /// По-хорошему бы переписать этот класс
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

            // Инициализация таймера для слайдера
            FontSliderTimer = new Timer();
            FontSliderTimer.Interval = 500;
            FontSliderTimer.Elapsed += FontSliderTimer_Elapsed;
            FontSliderTimer.AutoReset = false;
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
        /// При выходе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            // Если заметка сохранена ранее и не изменялась
            if (_viewModel.NoteSaved == true)
            {
                this.Close();
                return;
            }

            // Если заметка пустая
            if (_viewModel.Title == String.Empty && _viewModel.Content == String.Empty)
            {
                this.Close();
                return;
            }

            // Выход без сохранения
            if (System.Windows.MessageBox.Show("Выйти без сохранения?", "Выход", MessageBoxButton.YesNoCancel) == MessageBoxResult.Yes)
            {
                this.Close();
                return;
            }
        }

        private void FontSlider_Loaded(object sender, RoutedEventArgs e)
        {
            FontSliderTimer_Elapsed(sender, default);
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
                TitleTextBox.FontSize = FontSlider.Value + 8; // FontSize по умолчанию 18
                DateTextBlock.FontSize = FontSlider.Value; // FontSize по умолчанию 12
                ContentTextBox.FontSize = FontSlider.Value + 4; // FontSize по умолчанию 14
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

        /// <summary>
        /// При закрытии окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Сохранение глобальных настроек
            Properties.Settings.Default.Save();
        }

        #endregion
    }
}
