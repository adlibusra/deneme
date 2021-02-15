using System;
using System.Collections.Generic;
using System.Linq;


namespace DictionaryKAvrami
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> AdYas = new Dictionary<string, int>();
            AdYas.Add("Büşra", 28);
            AdYas.Add("Ömer", 30);
            AdYas.Add("Aynur", 45);
            AdYas.Add("İlayda", 19);


            foreach (var degeroku in AdYas)
            {
                Console.WriteLine(degeroku);
            }

            var eleman = AdYas.Count();
            Console.WriteLine();
            Console.WriteLine("Eleman sayılsı:  " + eleman);
           

            AdYas.Remove("Ömer");
            Console.WriteLine();
            Console.WriteLine();
            foreach (var degeroku in AdYas)
            {
                Console.WriteLine(degeroku);
            }

            
            Console.ReadLine();
        }
        }
}
