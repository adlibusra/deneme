using System;

namespace OOP4 // interface içinde imza metotları olur
{
    class FileLoggerService : ILogerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya Loglandı");
        }

    }
}
