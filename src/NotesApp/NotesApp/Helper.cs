using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesApp
{
    internal class Helper
    {
        /// <summary>
        /// Запрещённые символы для названий файлов
        /// </summary>
        private static readonly char[] _blackListChars = { '<', '>', ':', '"', '/', '|', '?', '*' };

        public static bool IsTxtFileName(string fileName)
        {
            if (fileName.EndsWith(".txt"))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Отфильтровать строку
        /// </summary>
        /// <param name="str"></param>
        /// <param name="charBlackList">Список символов, которые нужно заменить</param>
        /// <param name="charValueToReplace">Заменяющий символ</param>
        /// <returns>Отфильтрованная строка без символов charBlackList</returns>
        public static string FilterFileName(string str, char charValueToReplace = '\0')
        {
            for (int i = 0; i < _blackListChars.Length; i++)
            {
                str = str.Replace(_blackListChars[i], charValueToReplace);
            }

            return str;
        }
    }
}
