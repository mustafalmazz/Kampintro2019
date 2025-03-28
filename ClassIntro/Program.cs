﻿using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Lionel Messi";
            kurs2  .IzlenmeOrani = 10;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Cristiano Ronaldo";
            kurs3.IzlenmeOrani = 7;

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);
            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3  };
            foreach (var kurs  in kurslar) //Burdaki kurs sadece takma isim 
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }

            Console.WriteLine("Hello World!");
        }
    }

    class Kurs
    {

        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
