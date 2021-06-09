using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BoraOke
{
    public class DataMember
    {
        private string namaMember;
        private int usiaMember;
        private int IDMember;
        public string NamaMember
        {
            get { return namaMember; }
        }

        public void input()
        {
            DataMember dataMember = new DataMember();
            Connect data = new Connect();
            Console.WriteLine("Masukkan data diri");
            Console.Write("ID member \t : ");
            dataMember.IDMember = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nama \t\t : ");
            dataMember.namaMember = Console.ReadLine();
            Console.Write("Usia\t\t : ");
            dataMember.usiaMember = Convert.ToInt32(Console.ReadLine());
            

            MySqlCommand command = new MySqlCommand("Insert into datamember(ID, Nama, Usia)  Values('" + dataMember.IDMember + "', '" + dataMember.namaMember + "', '" + dataMember.usiaMember + "')", data.Connection);
            int i = command.ExecuteNonQuery();
            if (i > 0)
            {
                Console.WriteLine("\n");
            }

            
          
        }

    }
}
