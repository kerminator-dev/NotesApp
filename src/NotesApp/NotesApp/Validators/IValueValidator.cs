namespace NotesApp.Validators
{
    internal interface IValueValidator<T>
    {
        /// <summary>
        /// Является ли значение корректным
        /// </summary>
        /// <param name="value">Значение для проверки</param>
        /// <returns>true - значение корректно, false - значение некорректно</returns>
        public bool Validate(T value);
    }
}
