using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoraOke
{
    public struct DataMember
    {
        private string namaMember;
        private int usiaMember;
        private int IDMember;

        public void input()
        {
            DataMember dataMember = new DataMember();

            Console.Write("Nama \t\t : ");
            dataMember.namaMember = Console.ReadLine();
            Console.Write("Usia\t\t : ");
            dataMember.usiaMember = Convert.ToInt32(Console.ReadLine());
            Console.Write("ID member \t : ");
            dataMember.IDMember = Convert.ToInt32(Console.ReadLine());
        }

    }
}
