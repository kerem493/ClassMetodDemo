using System;

namespace ClassMetodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri mus1 = new Musteri();
            mus1.Ad = "Kerem";
            mus1.Soyad = "KORKMAZ";
            mus1.yas = 26;

            Musteri mus2 = new Musteri();
            mus2.Ad = "Gökay Selçuk";
            mus2.Soyad = "KORKMAZ";
            mus2.yas = 20;

            Musteri[] musteriler = new Musteri[] {mus1,mus2};

            foreach (var muss in musteriler)
            {
                Console.WriteLine("Adı : "+mus1.Ad +" Soyadı : "+mus1.Soyad+" Yaş : "+mus1.yas);
                Console.WriteLine("Adı : " + mus2.Ad + " Soyadı : " + mus2.Soyad + " Yaş : "+ mus2.yas);
                Console.WriteLine();
                Console.WriteLine();
            }


            MusteriManager musteriManager = new MusteriManager();
            Console.WriteLine("---------------");
            musteriManager.Ekle(mus1);
            musteriManager.Ekle(mus2);
            Console.WriteLine("---------------");
            Console.WriteLine("Müşteriler");
            musteriManager.Listele(mus1);
            musteriManager.Listele(mus2);
            Console.WriteLine("---------------");
            musteriManager.Sil(mus1);
            musteriManager.Sil(mus2);
        }
    }
}
