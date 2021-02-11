using System;

namespace odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.Id = 1;
            urun1.UrunAdi = "pantolon";
            urun1.Beden = "m";
            urun1.Renk = "mavi";

            Product urun2 = new Product();
            urun2.Id = 2;
            urun2.UrunAdi = "Gömlek";
            urun2.Beden = "s";
            urun2.Renk = "sarı";

            Product urun3 = new Product();
            urun3.Id = 3;
            urun3.UrunAdi = "kazak";
            urun3.Beden = "l";
            urun3.Renk = "kırmızı";

            Product[] urunler = new Product[] 
            { urun1,urun2,urun3};

            Console.WriteLine("For Döngüsü");
            for (int i = 0; i <urunler.Length ; i++)
            {
                Console.WriteLine(urunler[i].UrunAdi);
                Console.WriteLine("-------------");
            }
            Console.WriteLine("---Forech----");
            foreach (Product urun in urunler)
            {
                Console.WriteLine("ID:" + urun.Id);
                Console.WriteLine("Adı:   " + urun.UrunAdi);
                Console.WriteLine("Beden:  " + urun.Beden);
                Console.WriteLine("REnk:  " + urun.Renk);
            }
           
            Console.ReadLine();

         }
        
    }
    class Product
    {
        public int Id { get; set; }
        public string UrunAdi { get; set; }
        public string  Renk { get; set; }
        public string Beden { get; set; }
    }
    
}
