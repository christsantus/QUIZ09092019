using System;

namespace QUIZ09092019
{
    class Program
    {
        static void Main(string[] args)
        {
            BangunDatar kelas = new BangunDatar();

             Console.WriteLine("Matematika Itu Menyenangkan");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("-------------------------------");
        
            BangunDatar.luaspersegi();
            Console.WriteLine("-------------------------------");
            BangunDatar.luassegitiga();
            Console.WriteLine("-------------------------------");
            BangunDatar.luaslingkaran();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("-------------------------------");

            BangunRuang papan = new BangunRuang();
            BangunRuang.volumebalok();
            Console.WriteLine("-------------------------------");
            BangunRuang.volumekubus();

        }
    }
}
