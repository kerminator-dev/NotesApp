namespace NotesApp.Extensions
{
    /// <summary>
    /// Класс c методами-расширениями для класаа String
    /// </summary>
    public static class StringExtension
    {
        /// <summary>
        /// Получить подстроку
        /// </summary>
        /// <param name="str">Строка, которую нужно обрезать</param>
        /// <param name="length">Размерность ожидаемой строки</param>
        /// <param name="appendEnd">Добавляемая в конец строка (если str превышает длину length)</param>
        /// <returns>Подстроку</returns>
        public static string Substring(this string str, int length, string appendEnd = "...")
        {
            if (str.Length < length)
                return str.TrimEnd();

            return str.Substring(0, length).TrimEnd() + appendEnd;
        }
    }
}
