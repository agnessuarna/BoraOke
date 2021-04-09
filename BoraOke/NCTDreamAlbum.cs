using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoraOke
{
    public class NCTDreamAlbum : album
    {
        public override void Search()
        {
            Console.WriteLine("========== Masukkan Judul Album ========== ");

            int Judul = 0;

            Console.WriteLine("(1) We BOOM");
            Console.WriteLine("(2) Reload ");
            Judul = Convert.ToInt32(Console.ReadLine());


            switch (Judul)
            {
                case 1:
                    Console.WriteLine("\n\tAlbum We BOOM");
                    Console.WriteLine("Realese Date : July 16, 2019");
                    Console.WriteLine("Track List   : 6 Song");
                    break;
                case 2:
                    Console.WriteLine("\n\tAlbum Reload");
                    Console.WriteLine("Realese Date : April 29, 2020");
                    Console.WriteLine("Track List   : 5 Song");
                    break;
            }

        }
    }
}

