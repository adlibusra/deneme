using System;
using System.Collections.Generic;
using System.Text;

namespace MusteriMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi. Adı ve soy adı: " + musteri.Ad + "  "+ musteri.Soyad);
        }
        public void MusteriListele(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Ad);
                Console.WriteLine(musteri.ID);
                Console.WriteLine(musteri.Soyad);
                Console.WriteLine(musteri.Tc);
                Console.WriteLine(musteri.Cinsiyet);
            }
        }
        public void MusteriSilme(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi. Adı ve soy adı:  " + musteri.Ad + "  "+ musteri.Soyad);
        }
    }
}
