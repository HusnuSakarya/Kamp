using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmeni = "Engin Demirop";
            kurs1.İzlemneOrani = 69;
            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.Egitmeni = "husn sasa";
            kurs2.İzlemneOrani = 54;
            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "python";
            kurs3.Egitmeni = "mevlüt taş";
            kurs3.İzlemneOrani = 99;
            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var abb in kurslar)
            {
                Console.WriteLine(abb.KursAdi+abb.Egitmeni);
            }
            
            
            
            Console.WriteLine();



       
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmeni { get; set; }
        public int İzlemneOrani { get; set; }
    }
}
