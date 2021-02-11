using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Kamp";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            // array dizi - Dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Kamp",
                "Programlamaya başlangıç için temel kurs",
                "Java", "python","c#"};


            for (int i=0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
                
            }
            Console.WriteLine("For bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("Sayfa sonu");
            Console.ReadLine();
        }
    }
}
