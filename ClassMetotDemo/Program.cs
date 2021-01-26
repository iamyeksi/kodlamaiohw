using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Yakup Kadri";
            musteri1.Soyad = "EKŞİ";
            musteri1.Yas = 21;
            musteri1.Id = "10394865";

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Emirhan";
            musteri2.Soyad = "TOPÇU";
            musteri2.Yas = 19;
            musteri2.Id = "38647569";

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Buse Birsen";
            musteri3.Soyad = "KÜÇÜKER";
            musteri3.Yas = 20;
            musteri3.Id = "54887244";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Ad+" " + musteri.Soyad+" " +musteri.Yas+" " +musteri.Id+" ");


                Console.WriteLine("-------------------------------");
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

            Console.WriteLine("------------------------");
            MusteriManager musteriManager2 = new MusteriManager();
            musteriManager.Sil(musteri3);
            
        }
    }
}
