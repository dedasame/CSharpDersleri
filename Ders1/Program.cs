using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //QWEQWEQWE

            Console.WriteLine("WELCOME PLAYER"); //Yazar ve alt satira gecer
            Console.Write("BYE!");//Yazar alt satira gecme yok!!
            Console.ReadLine();  //Konsolun kaybolmasini onler. Kullanicidan veri alir.

            //Tur Donusumu 

            string age = Console.ReadLine(); //kullanicidan her zaman string alinir.

            int a = Convert.ToInt32(age);

            int b = int.Parse(age);

            Console.WriteLine("Toplam = " + (a + b)); //Karisiklik olmasin diye bir parantez daha ekliyoruz.

            // break; continue;

            //arrays

            int[] sayilar = new int[4]; // sayilar[i] = Convert.ToInt32(Console.ReadLine());
            string[] isimler = { "Name", "Name2", "Name3" };

            //for each dongusu

            foreach (string name in isimler)
            {
                Console.WriteLine(name);
            }

        }
    }
}
