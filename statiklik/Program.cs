using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statiklik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // STATIC -> class'a özgü nesneden nesneye değişmeyen kısımlar için.
            // obje oluşturmadan class isminden bir metoda ulaşmak için kullaniriz.
            // class'a özgü bir metot için 
            // Static metot-degisken-ctor-class

            // STATIC METOT
            Personel p = new Personel("username kısmı",666);
            p.bilgi();
            Personel.staticbilgi(); //herhangi bir obje olmadan calisir.

            // STATIC DEGISKEN
            p.id = 1;
            p.isim = "Lain";
            //p.maas  -> obje uzerinden değil class üzerinden erişim var.
            Personel.maas = 5000;

            // STATIC CONSTRUCTOR

            p.gosterctor();
            p.yenikod(3);
            p.gosterctor();

            






            Console.ReadLine();

        }
    }
}
