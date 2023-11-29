using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alistirma
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string tc;

            Console.Write("TC Kimliginizi Girin: ");
            tc = Console.ReadLine();

            Personel p = new Personel();
            p.TCNO = tc;

            Console.WriteLine("TC: " + p.TCNO);

            Console.ReadLine();
            



        }
    }
}
