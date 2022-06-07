namespace NotesApp.Validators
{
    internal interface IValueValidator<T>
    {
        /// <summary>
        /// Является ли значение корректным
        /// </summary>
        /// <param name="value">true - значение корректно, false - значение некорректно</param>
        /// <returns>true/false</returns>
        public bool Validate(T value);
    }
}
