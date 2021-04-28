using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BoraOke
{
    class RedVelvetAlbum : album
    {
        public override void Search()
        {
            Console.WriteLine("========== Judul Album =========== ");
            Connect data = new Connect();
            using (data.Connection)
            {
                try
                {

                    MySqlCommand command = data.Connection.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "Select * from redvelvetalbum";


                    MySqlDataReader reader = command.ExecuteReader();

                    var data1 = "ID \t    Judul Album \n";

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            data1 += reader.GetInt32(0) + "\t\t" + reader.GetString(1) + "\t\t" + Environment.NewLine;
                        }
                        Console.WriteLine(data1);
                    }
                    else
                    {
                        Console.WriteLine("===Album tidak Ada===");
                    }
                    reader.Close();

                    Console.WriteLine("-------------------------------------------------------");
                    int ID = 0;
                    Console.Write(" Masukkan ID Album yang akan dipinjam  :  ");
                    ID = Convert.ToInt32(Console.ReadLine());
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "Select * from redvelvetalbum where id_Album in (" + ID + ")";

                    MySqlDataReader rd = command.ExecuteReader();

                    var data2 = "ID \t      Judul Album \t    Realease Album \t Track List : Song \n";

                    if (rd.HasRows)
                    {
                        while (rd.Read())
                        {
                            data2 += rd.GetInt32(0) + "\t\t" + rd.GetString(1) + "\t\t" + rd.GetDateTime(2) + "\t\t" + rd.GetInt32(3) + Environment.NewLine;
                        }
                        Console.WriteLine(data2);
                    }
                    else
                    {
                        Console.WriteLine("===Album tidak Ada===");
                    }

                    reader.Close();

                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    System.Console.WriteLine("Error : " + ex.Message.ToString());
                }
                finally
                {
                    Console.WriteLine("==Press any keys==");
                    Console.ReadKey();
                }
            }

        }

    }
}

