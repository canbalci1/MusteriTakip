using System;

namespace MusteriTakip
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri() {Ad ="Can", Soyad = "Balcı", id = 19191919 , Bakiye =10000 };
            Musteri musteri2 = new Musteri() { Ad = "Aylin", Soyad = "Şeker", id = 254515457, Bakiye = 20000 };
            Musteri musteri3 = new Musteri() { Ad = "Çağatay", Soyad = "Bayrak", id = 36975451, Bakiye = 30000 };



            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Listele(musteriler);


        }
    }
}
