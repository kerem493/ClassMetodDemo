using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetodDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri mus)
        {
            Console.WriteLine(mus.Ad+" " +mus.Soyad + " " +"Sisteme eklendi.");
        }
        public void Listele(Musteri mus)
        {
            Console.WriteLine(mus.Ad + " " + mus.Soyad);
        }
        public void Sil(Musteri mus)
        {
            Console.WriteLine(mus.Ad + " " + mus.Soyad + " " + "Sistemden silindi.");
        }
    }
}
