using System;

namespace QUIZ09092019
{
    class BangunDatar
    {
        public static void luaspersegi()
        {
            Console.WriteLine("Menghitung Luas Persegi");

            int sisi, luas;

            Console.Write("Masukan nilai sisi = ");
            sisi = Convert.ToInt32(Console.ReadLine());

            luas = sisi*sisi;

            Console.WriteLine(" Luas Persegi adalah "+luas);
        }

        public static void luassegitiga()
        {
            Console.WriteLine("Menghitung Luas Segitiga");

            int alas, tinggi, luas;

            Console.Write("Masukan nilai alas = ");
            alas = Convert.ToInt32(Console.ReadLine());

             Console.Write("Masukan nilai tinggi = ");
            tinggi = Convert.ToInt32(Console.ReadLine());

            luas = alas*tinggi/2;

            Console.WriteLine(" Luas segitiga adalah "+luas);
        }

        public static void luaslingkaran()
        {
            Console.WriteLine("Menghitung Luas lingkaran");

            int luas, jari;

            Console.Write("Masukan nilai jari = ");
            jari = Convert.ToInt32(Console.ReadLine());


            luas = 314*jari*jari/100;

            Console.WriteLine(" Luas lingkaran adalah "+luas);
        }

    }
}