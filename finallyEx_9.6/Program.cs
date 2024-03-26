namespace finallyEx_9._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Exception[] exceptions = new Exception[]
            {
                new DivideByZeroException(),
                new IndexOutOfRangeException(),
                new ArgumentNullException(),
                new InvalidOperationException(),
                new MyExeption("Ошибка в компуктере.")
            };
            foreach (var exception in exceptions)
            {
                try
                {
                    ThrowException(exception);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Исключение {ex.GetType().Name}: {ex.Message}");
                }
                
            }
        }
        static void ThrowException(Exception exception)
        {
            // Генерируем исключение
            throw exception;
        }
    }
    class MyExeption: Exception
    {
        public MyExeption()
        {
            
        }
        public MyExeption(string message): base (message)
        {
            
        }
    }

}
