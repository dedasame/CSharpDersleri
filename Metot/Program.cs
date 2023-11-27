using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metot
{
    internal class Program
    {
        static void Main(string[] args)
        {

            hello();


            Console.WriteLine(plus(5, 7));

            int a = plus(20, 10);

            Console.WriteLine(a);

            Console.ReadLine();
        }

        static void hello()
        {
            Console.WriteLine("HELLO");
        
        }

        static int plus(int a, int b)
        {
            return a + b;

        }







    }
}
