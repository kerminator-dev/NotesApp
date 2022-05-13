using System;

namespace NotesApp.Extensions
{
    /// <summary>
    /// Класс c методами-расширениями для класаа DateTime
    /// </summary>
    public static class DateTimeExtension
    {
        /// <summary>
        /// Преобразвать DateTime в строку-тип DateTime для SQLite формата dd-mm-yyyy hh:mm:ss
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns>Строка dateTime</returns>
        public static string ToSQLiteDateTimeString(this DateTime dateTime)
        {
            return dateTime.ToString("yyyy-MM-dd hh:mm:ss");
        }

        /// <summary>
        /// Преобразовать DateTime в строку формата dd.mm.yyyy hh:mm:ss
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns>Строка dateTime</returns>
        public static string ToShortDateTimeString(this DateTime dateTime)
        {
            return $"{dateTime.ToShortDateString()} {dateTime.ToShortTimeString()}";
        }
    }
}
