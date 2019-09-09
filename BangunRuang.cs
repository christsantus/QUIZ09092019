using System;

namespace QUIZ09092019
{
    class BangunRuang
    {
        public static void volumebalok()
        {
                
            Console.WriteLine("Menghitung Volume Balok");

            int panjang, lebar, tinggi, volume;

            Console.Write("Masukan nilai panjang = ");
            panjang = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukan nilai lebar = ");
            lebar = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukan nilai tinggi = ");
            tinggi = Convert.ToInt32(Console.ReadLine());

            volume = panjang*lebar*tinggi;
            
            Console.WriteLine(" Volume Balok adalah "+volume);
        }

         public static void volumekubus()
        {
            Console.WriteLine("Menghitung Volume Kubus");

            int sisi, volume;

            Console.Write("Masukan nilai sisi = ");
            sisi = Convert.ToInt32(Console.ReadLine());

            volume = sisi*sisi*sisi;

            Console.WriteLine(" Luas Persegi adalah "+volume);
        }

    }
}
