using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;

            Kurs kurs1 =new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.KursunEgitmeni = "Engin Demioğ";
            kurs1.İzlenmeorani = "68";

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.KursunEgitmeni = "Kerem Varış";
            kurs2.İzlenmeorani = "50";

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.KursunEgitmeni = "Berkay Bilgin";
            kurs3.İzlenmeorani = "80";

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursunEgitmeni);
            }
            //Console.WriteLine(kurs1.KursAdi + " :" + kurs1.KursunEgitmeni);
            Console.ReadLine();

        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursunEgitmeni { get; set; }
        public string İzlenmeorani { get; set; }
    }
}
