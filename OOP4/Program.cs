using System;
using System.Collections.Generic;

namespace OOP4
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager(); //instıns üretti
           

            IKrediManager tasitKrediManager = new TasitKrediManager();
          
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafKrediManager = new EsnafKrediManager();

            ILogerService databaseLoggerService = new DatabaseLoggerService();
            ILogerService fileLogerService = new FileLoggerService();
            

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(esnafKrediManager, new SmsLogerService());

            List<IKrediManager> krediler = new List<IKrediManager>() { esnafKrediManager , tasitKrediManager }; 
            // liste olusturup listeye ekliyoruz talepleri //

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

            



            Console.ReadLine();
        }
    }
}
