using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi1 = " Elma";
            double fiyati1 = 15;
            string aciklama1 = "Amasya Elması";


            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 25;
            urun1.Id = 36;
            urun1.Aciklama = "Amasya Elması";

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 125;
            urun2.Id = 388;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Product urun3 = new Product();
            urun3.Adi = "Biber";
            urun3.Fiyati = 3125;
            urun3.Id = 444;
            urun3.Aciklama = "Kırmızı Biber";

            Product[] urunler = new Product[]
            {
                urun1,urun2,urun3
            };
            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Aciklama) ;
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Id);
                Console.WriteLine("------------");

            }
            Console.WriteLine("---------Metotlar-----------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yşil armet", 12,6);
            sepetManager.Ekle2("Elam", "kırmızı elma", 52,2);
            sepetManager.Ekle2("karpuz", "diyarnakır", 12,3);






        }
    }
}
