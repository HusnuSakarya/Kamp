﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Product urun)
        {
            Console.WriteLine("Sepete eklendi:"+urun.Adi );

        }
        public void Ekle2(string urunAdi, string aciklama, int fiyat,int stokAdedi)
        {
            Console.WriteLine("tebrikler:"+urunAdi);
        }
    }
}
