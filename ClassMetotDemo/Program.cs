using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Nazlı";
            musteri1.Soyadi="Zaman";
            musteri1.KimlikNo = 123456789;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Kaan";
            musteri2.Soyadi = "Gün";
            musteri2.KimlikNo = 987654321;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            Console.WriteLine("Müşteri Bilgileri :");
            Console.WriteLine("-----------------------------");

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Adı : " + musteri.Adi);
                Console.WriteLine("Soyadı : " + musteri.Soyadi);
                Console.WriteLine("kimlik No : " + musteri.KimlikNo);
                Console.WriteLine("-----------------------------");
            }

            MusteriManager musteriManager= new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriListele(musteri1);
            musteriManager.MusteriSil(musteri1);

            Console.WriteLine("-----------------------------");

            MusteriManager musteriManager2 = new MusteriManager();
            musteriManager2.MusteriEkle(musteri2);
            musteriManager2.MusteriListele(musteri2);
            musteriManager2.MusteriSil(musteri2);


            Console.Read();

        }
    }
}
