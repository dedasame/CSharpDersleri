using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int kapiSayisi = 4;
            string model = "Ferrari";
            string renk = "Kırmızı";

            Araba car1 = new Araba(kapiSayisi,model,renk);

            /*
            car1.kapiSayisi = 4;
            car1.renk = "Kırmızı";
            car1.model = "Ferrari";
            */


            car1.motorcalistir();
            car1.arabayikilitle();
            Console.WriteLine("Kapi sayisi: " + car1.kapiSayisi);
            Console.WriteLine("Renk: " + car1.renk);
            Console.WriteLine("Model: " + car1.model);


            // public : 
            // private : class dışı erişilemez. özel degişkenler.
            // protected :
            // internal :


            Console.ReadLine();


        }



    }
}
