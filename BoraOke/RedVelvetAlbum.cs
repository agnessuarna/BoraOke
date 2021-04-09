using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoraOke
{
    class RedVelvetAlbum : album
    {
        public override void Search()
        {
            Console.WriteLine("========== Masukkan Judul Album ========== ");

            int Judul = 0;

            Console.WriteLine("(1) Ice Cream Cake");
            Console.WriteLine("(2) Russian Roulette");
            Console.WriteLine("(3) The ReVe Festival Finale");
            Judul = Convert.ToInt32(Console.ReadLine());


            switch (Judul)
            {
                case 1:
                    Console.WriteLine("\n\tAlbum Ice Cream Cake");
                    Console.WriteLine("Realese Date : September 9, 2015");
                    Console.WriteLine("Track List   : 6 Song");
                    break;
                case 2:
                    Console.WriteLine("\n\tAlbum Russian Roulette");
                    Console.WriteLine("Realese Date : September 7, 2016");
                    Console.WriteLine("Track List   : 7 Song");
                    break;
                case 3:
                    Console.WriteLine("\n\tAlbum The ReVe Festival Finale");
                    Console.WriteLine("Realese Date : December 23, 2019");
                    Console.WriteLine("Track List   : 16 Song");
                    break;
            }
        }
    }
}
