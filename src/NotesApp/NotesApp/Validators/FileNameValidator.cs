using System.IO;

namespace NotesApp.Validators
{
    internal class FileNameValidator : IValueValidator<string>
    {
        public bool Validate(string value)
        {
            return value.IndexOfAny(Path.GetInvalidFileNameChars()) < 0;
        }
    }
}
