using System;
using MySql.Data.MySqlClient;

namespace BoraOke
{
    public struct Kegiatan
    {
        private int Boyband;
        private int lama_peminjam;
        private DateTime _deadline;
        private static bool pinjam = false;
        private string namaAlbum;
        private DateTime Tglmeminjam;

        public string NamaAlbum
        {
            get { return namaAlbum; }
            set { namaAlbum = value; }
        }
        
        public DateTime deadline
        {
            get { return _deadline; }
            set { _deadline = value; }
        }

        public DateTime tglmeminjam
        {
            get { return Tglmeminjam; }
            set { Tglmeminjam = value; }
        }
        public int _LamaPeminjaman
        {
            get { return lama_peminjam; }
            set { lama_peminjam = value; }
        }

        public void insert()
        {
            DataMember dataMember = new DataMember();
            Connect data = new Connect();
            data.Connection.Open();
            MySqlCommand command = new MySqlCommand("Insert into peminjaman(tanggal_peminjaman, lama_peminjaman, nama_peminjam, album_peminjam,  tanggal_pengembalian)  Values( '" + tglmeminjam + "', '" + _LamaPeminjaman + "','" + dataMember.NamaMember + "', '" + NamaAlbum + "',  '" + deadline + "')", data.Connection);
            int i = command.ExecuteNonQuery();
            if (i > 0)
            {
                Console.WriteLine("\n==Data Peminjaman telah diubah==");
            }
        }

        public void tanggalmeminjam()
        {

            Console.WriteLine("\n-----Tanggal Peminjaman-----\n");
            Console.Write("Tanggal  \t\t : ");
            int day = int.Parse(Console.ReadLine());
            Console.Write("Bulan (dalam angka)\t : ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Tahun \t\t\t : ");
            int year = int.Parse(Console.ReadLine());

            DateTime aDate = new DateTime(year, month, day);
            Console.Write("\ntanggal Peminjaman \t: ");
            Console.WriteLine(aDate.ToString("dd MM yyyy"));

            Console.WriteLine("\n====== Lama Peminjaman =====");
            Console.WriteLine("pilih lama peminjaman \n (3) \t(5) \t(7)");
            lama_peminjam = Convert.ToInt32(Console.ReadLine());

            if (lama_peminjam == 3)
            {
                deadline = aDate.AddDays(3);
                Console.WriteLine("\nTanggal pengembalian \t:  {0:dd} {0:y} ", deadline);
                pinjam = true;
 
            }
            else
            if (lama_peminjam == 5)
            {
                deadline = aDate.AddDays(5);
                Console.WriteLine("\nTanggal pengembalian \t:  {0:dd} {0:y} ", deadline);
                pinjam = true;
            }
            else
            if (lama_peminjam == 7)
            {
                deadline = aDate.AddDays(7);
                Console.WriteLine("\nTanggal pengembalian \t:  {0:dd} {0:y} ", deadline);
                pinjam = true;
            }
            else
                Console.WriteLine("\nDenda");



        }

        public void meminjam()
        {
            Console.WriteLine("\n\t\t\t=======PEMBERITAHUAN======= \n****Bahwa hanya dapat melakukan peminjaman maksimal 1 album setiap kali peminjaman****");
            Console.WriteLine("\n============ Masukkan nama Boyband atau Girlband ============= ");

            Boyband = 0;

            Console.WriteLine("(1) EXO");
            Console.WriteLine("(2) NCT Dream");
            Console.WriteLine("(3) NCT 127");
            Console.WriteLine("(4) Aespa");
            Console.WriteLine("(5) Red Velvet");
            Boyband = Convert.ToInt32(Console.ReadLine());

            switch (Boyband)
            {
                case 1:
                    EXOAlbum AlbumEXO = new EXOAlbum();
                    AlbumEXO.Search();
                    break;
                case 2:
                    NCTDreamAlbum AlbumNCTDream = new NCTDreamAlbum();
                    AlbumNCTDream.Search();
                    break;
                case 3:
                    NCT127Album AlbumNCT127 = new NCT127Album();
                    AlbumNCT127.Search();
                    break;
                case 4:
                    AespaAlbum AlbumAespa = new AespaAlbum();
                    AlbumAespa.Search();
                    break;
                case 5:
                    RedVelvetAlbum AlbumRedVelvet = new RedVelvetAlbum();
                    AlbumRedVelvet.Search();
                    break;
            }


        }

        public void mengembalikan()
        {
            if (pinjam == true)
            {
                Console.Write("\nTanggal Pengembalian Seharusnya : ");
                DateTime aDate = deadline;
                Console.WriteLine(aDate.ToString("dd MMMM yyyy"));

                DateTime due = DateTime.Now;
                Console.Write("\nTanggal Hari ini \t :  ");
                Console.WriteLine(due.ToString("dd MMMM yyyy"));

                var lama = (due - aDate).Days;
                Console.WriteLine("\ntelat pengembalian {0} hari ", lama);

                if (lama >= 0)
                {
                    int denda = 0;
                    denda = 5000 * lama;
                    Console.WriteLine("\nTotal Denda = {0}", denda);
                    Console.WriteLine("\n>>>>>Silakan membayar denda ke tempat petugas<<<<<");
                }
                else
                {
                    Console.WriteLine("Anda tidak terkena denda");
                }

            }
            else
            {
                Console.WriteLine("Anda belum meminjam");
            }
        }
    }
}
