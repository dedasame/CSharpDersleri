using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace publicprivate
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // public private

            musteri m1 = new musteri();

            m1.isim = "Lain";
            m1.soyisim = "Iwakura";
            m1.maas = 5000;
            m1.cinsiyet = "dc";

            // m1.yas = 15; -> private : class dışı erişilemez.





        }
    }
}
