namespace NotesApp.Data
{
    /// <summary>
    /// Класс-хранилище текущего источника данных (БД, .txt и т. д.)
    /// </summary>
    public class DataSourceContainer
    {
        private static IDataSource? _dataSource;

        public static IDataSource GetInstance()
        {
            if (_dataSource == null)
            {
                _dataSource = new TXTDataSource(); // по умолчанию
            }

            return _dataSource;
        }


        public static IDataSource GetInstance(IDataSource dataSource)
        {
            if (_dataSource == null)
            {
                _dataSource = dataSource;
            }

            return _dataSource;
        }
    }
}

