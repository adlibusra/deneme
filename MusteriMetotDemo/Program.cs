using System;

namespace MusteriMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Büşra";
            musteri1.ID = 1;
            musteri1.Soyad = "ÇAlışkan";
            musteri1.Tc = "464648643246";
            musteri1.Cinsiyet = "Kadın";

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Kamil";
            musteri2.ID = 2;
            musteri2.Soyad = "Durgun";
            musteri2.Tc = "654634556";
            musteri2.Cinsiyet = "Erkek";
            
            

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            

            Console.WriteLine("------------------");

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.MusteriListele(musteriler);
            Console.WriteLine("------------------");

            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            Console.WriteLine("------------------");

            musteriManager.MusteriSilme(musteri1);
            musteriManager.MusteriSilme(musteri2);





            Console.ReadLine();

            }


        }
    }

