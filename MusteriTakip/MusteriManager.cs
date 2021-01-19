using System;
using System.Collections.Generic;
using System.Text;

namespace MusteriTakip
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("{0} isimli müşteri sisteme eklendi" , musteri.Ad);
        }
        public void Listele(Musteri[] musterilist)
        {
            foreach (var musteri in musterilist)
            {
                Console.WriteLine(musteri.Ad +" " + musteri.Soyad + " "+   musteri.Bakiye +" "+ musteri.id);
            }
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("{0} isimli müşteri sistemden silindi", musteri.Ad);
        }

    }
}
