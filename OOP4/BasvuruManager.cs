using System;
using System.Collections.Generic;
using System.Text;

namespace OOP4
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager ,List <ILogerService> loggerServices) // implemente etti
        {
            // Başvuran bilgilerini değerlendirme 
            //
            krediManager.Hesapla();
            foreach (var loggerservice in loggerServices)
            {
                loggerservice.Log();
            }
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler )  // liste olusturdum 
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }

        internal void KrediOnBilgilendirmesiYap(List<IhtiyacKrediManager> krediler)
        {
            throw new NotImplementedException();
        }

    }
}
