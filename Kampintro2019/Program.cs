using System;

namespace Kampintro2019
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirme";
            string kurs2 = "Programlamaya Başlangıç";
            string kurs3 = "Java";

            string[] kurslar = new string[] { "Yazılım Geliştirme", "Programlamaya Başlangıç", "Java" };

            for (int i = 0; i < kurslar.Length; i++) 
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For Bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu - Footer");
        }
    }
}
