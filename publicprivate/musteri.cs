using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace publicprivate
{
    internal class musteri
    {
        public string isim;
        public string soyisim;
        public int maas;
        public string cinsiyet;
        private int yas;

        public musteri()
        {
            Console.WriteLine("Musteri sinifinin constructor metotu calisti.");
        }



        public void bilgigoster()
        {
            Console.WriteLine("Name: " + isim, " " + soyisim);
            Console.WriteLine("Maas: " + maas);
            Console.WriteLine("Cinsiyet: " + cinsiyet);
            Console.WriteLine("Age: " + yas);

        }

        private void isimgoster(string isim,string soyisim)
        {
            Console.WriteLine("Name & Surname: "+isim+" "+soyisim);

        }







    }
}
