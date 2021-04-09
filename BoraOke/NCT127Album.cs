using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoraOke
{
    class NCT127Album : album
    {
        public override void Search()
        {
            Console.WriteLine("=========== Masukkan Judul Album ==========");

            int Judul = 0;

            Console.WriteLine("(1) Neo Zone");
            Console.WriteLine("(2) We Are Superhuman ");
            Console.WriteLine("(3) Regulate");
            Judul = Convert.ToInt32(Console.ReadLine());


            switch (Judul)
            {
                case 1:
                    Console.WriteLine("\n\tAlbum Neo Zone");
                    Console.WriteLine("Realese Date : March 6 2020");
                    Console.WriteLine("Track List   : 13 Song");
                    break;
                case 2:
                    Console.WriteLine("\n\tAlbum We Are Superhuman");
                    Console.WriteLine("Realese Date : May 24, 2019");
                    Console.WriteLine("Track List   : 6 Song");
                    break;
                case 3:
                    Console.WriteLine("\n\tAlbum Regulate");
                    Console.WriteLine("Realese Date : November 24, 2018");
                    Console.WriteLine("Track List   : 14 Song");
                    break;
            }
        }
    }
}
