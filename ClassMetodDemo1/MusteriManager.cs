using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetodDemo1
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri) 
        {
            Console.WriteLine("Musteri Eklendi");
            Console.WriteLine("Müşteri eklendi : " + musteri.MusteriAdi + " " + musteri.MusteriSoyadi+" "+musteri.MusteriDogumYeri+" "+musteri.TcNo);
        }
        public void Listele(Musteri musteri) 
        {
            Console.WriteLine("Musteri Listelendi");
            Console.WriteLine("Müşteri Listelendi : " + musteri.MusteriAdi + " " + musteri.MusteriSoyadi + " " + musteri.MusteriDogumYeri + " " + musteri.TcNo);
        }
        public void Silme(Musteri musteri)
        {
            Console.WriteLine("Musteri Silindi");
            Console.WriteLine("Müşteri Silindi : " + musteri.MusteriAdi + " " + musteri.MusteriSoyadi + " " + musteri.MusteriDogumYeri + " " + musteri.TcNo);
        }
    }
}
