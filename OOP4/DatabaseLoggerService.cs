using System;
using System.Collections.Generic;
using System.Text;

namespace OOP4 // interface içinde imza metotları olur
{
    class DatabaseLoggerService : ILogerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı ");
        }
    }
}
