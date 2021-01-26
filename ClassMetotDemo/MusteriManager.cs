using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Sisteme müşteri eklendi.");
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " " + musteri.Yas + " " + musteri.Id + " ");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Sistemden müşteri silindi.");
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " " + musteri.Yas + " " + musteri.Id + " ");
        }
        public void Ara(Musteri musteri)
        {
            Console.WriteLine("Müşteri aranıyor : " + musteri.Ad);
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " " + musteri.Yas + " " + musteri.Id + " ");
        }
        public void MesajGonder(Musteri musteri)
        {
            Console.WriteLine("Müşteriye mesaj gönderildi! : " + musteri.Id);
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " " + musteri.Yas + " " + musteri.Id + " ");
        }

    }
}
