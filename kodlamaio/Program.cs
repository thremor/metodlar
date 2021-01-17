using System;

namespace kodlamaio
{
    class Program
    {
        static void Main(string[] args)
        {

            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Acıiklama = "Amasya elması";
            urun1.StokAdedi = 100;

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 80;
            urun2.Acıiklama = "Hatay karpuzu";
            urun2.StokAdedi = 86;

            Urun[] urunler = new Urun[] { urun1, urun2 };


            //typ-safe -- tip güvenliği
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Acıiklama);
                Console.WriteLine(urun.StokAdedi+"kg");
                Console.WriteLine("----------------");

            }

            Console.WriteLine("------Metodlar-------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12,10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12,9);
            sepetManager.Ekle2("Karpuz", "Hatay karpuzu", 12,8);
        }

    }
}


//Dont repeat yourself - DRY - kendini tekrar etme - clean Code - Best Practive