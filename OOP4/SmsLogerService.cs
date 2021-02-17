using System;
using System.Collections.Generic;
using System.Text;

namespace OOP4
{
    class SmsLogerService : ILogerService
    {
        public void Log()
        {
            Console.WriteLine("Sms Yollandı");
        }
    }
}
