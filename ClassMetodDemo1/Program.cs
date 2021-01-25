using System;

namespace ClassMetodDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.TcNo = "20220202020";
            musteri1.MusteriAdi = "Gamze";
            musteri1.MusteriSoyadi = "Unsal";
            musteri1.MusteriDogumYeri = "Ankara";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.TcNo = "20212021202";
            musteri2.MusteriAdi = "Celal";
            musteri2.MusteriSoyadi = "Kun";
            musteri2.MusteriDogumYeri = "Kahramanmaras";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2,};
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.MusteriAdi + " " + musteri.MusteriSoyadi);
                Console.WriteLine(musteri.TcNo + " " + musteri.Id+" "+musteri.MusteriDogumYeri);
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

            MusteriManager musteriManager1 = new MusteriManager();
            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);

            MusteriManager musteriManager2 = new MusteriManager();
            musteriManager.Silme(musteri1);
            musteriManager.Silme(musteri2);

        }
    }
}
