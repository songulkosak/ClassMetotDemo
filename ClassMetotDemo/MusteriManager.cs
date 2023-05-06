using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müşteri ekleme işlemi başarıyla tamamlandı.\nMüşteri Adı : " + musteri.Adi);
        }
        public void MusteriListele(Musteri musteri)
        {
            Console.WriteLine("Müşteriler : \n" + musteri.Adi  +musteri.Soyadi);
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Müşteri silme işlemine devam etmek istermisiniz? ");
        }
    }
}
