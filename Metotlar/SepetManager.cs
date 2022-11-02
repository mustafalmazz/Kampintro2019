using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        // parametre burda parantez içindeki ürün
        // bir classta birden fazla metot olabilr örn ekle 1 ekle 2 veya toplama çıkarma 
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler! Sepete Eklendi : " + urun.Adi );
             
        }
        public void Ekle2(string urunAdi, string aciklama, double fiyat )
        {
            Console.WriteLine("Tebrikler! Sepete Eklendi : " + urunAdi);
        }
         
    }
}
