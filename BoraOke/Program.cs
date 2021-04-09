using System;

namespace BoraOke
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========================================\n");
            Console.WriteLine("---Selamat Datang di Situs Album Kpop---\n");

            DataMember dataMember = new DataMember();
            dataMember.input();

            Console.WriteLine("==========*Silakan Pilih Menu*===========\n");

            int opsi = 0;
            Console.WriteLine("|(1) Peminjaman                          |");
            Console.WriteLine("|(2) Pengembalian                        |");
            opsi = Convert.ToInt32(Console.ReadLine());

            Kegiatan kegiatan = new Kegiatan();
            switch (opsi)
            {
                case 1:
                    kegiatan.meminjam();
                    kegiatan.tanggalmeminjam();

                    int pilih = 0;
                    Console.WriteLine("\nIngin Melakukan Pengembalian? (1) 'YA'; (2)'TIDAK'");
                    pilih = Convert.ToInt32(Console.ReadLine());
                    if (pilih == 1) { kegiatan.mengembalikan();}
                                     
                     Console.WriteLine("====Terima kasih telah berkunjung di situs ini====");
                    break;
                case 2:
                    kegiatan.mengembalikan();
                    break;
                default:
                    break;

            }

        }
    }
}
