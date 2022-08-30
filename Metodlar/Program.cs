using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama="Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır";

            Urun[] urunler = new Urun[] {urun1, urun2 };


            //type -safe  --tip güvenli oldugundan x den önce Urun yazdık
            foreach (Urun x in urunler)
            {
                Console.WriteLine(x.Adi);
                Console.WriteLine(x.Aciklama);
                Console.WriteLine(x.Fiyati);
                Console.WriteLine("----------------------");


            }

            Console.WriteLine("----------------------Metodlar-----------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            

            Console.ReadLine();



        }
    }
}
