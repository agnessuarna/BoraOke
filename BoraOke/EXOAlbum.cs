using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoraOke
{
    public class EXOAlbum : album
    {
        public override void Search()
        {
            Console.WriteLine("========== Masukkan Judul Album =========== ");
            int Judul = 0;

            Console.WriteLine("(1) XOXO");
            Console.WriteLine("(2) OBSESSION");
            Console.WriteLine("(3) EXODUS");
            Console.WriteLine("(4) EX'ACT");
            Console.WriteLine("(5) The War");
            Judul = Convert.ToInt32(Console.ReadLine());


            switch (Judul)
            {
                case 1:
                    Console.WriteLine("\n\tAlbum XOXO");
                    Console.WriteLine("Realese Date : June 11, 2013");
                    Console.WriteLine("Track List   : 14 Song");
                    break;
                case 2:
                    Console.WriteLine("\n\tAlbum OBSESSION");
                    Console.WriteLine("Realese Date : November 29, 2019");
                    Console.WriteLine("Track List   : 10 Song");
                    break;
                case 3:
                    Console.WriteLine("\n\tAlbum EXODUS");
                    Console.WriteLine("Realese Date : March 30, 2015");
                    Console.WriteLine("Track List   : 10 Song");
                    break;
                case 4:
                    Console.WriteLine("\n\tAlbum EX'ACT");
                    Console.WriteLine("Realese Date : August 18, 2016");
                    Console.WriteLine("Track List   : 11 Song");
                    break;
                case 5:
                    Console.WriteLine("\n\tAlbum The War");
                    Console.WriteLine("Realese Date : July 18, 2017");
                    Console.WriteLine("Track List   : 9 Song");
                    break;
            }
        }

    }
}

