using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Encapsulation: private tanimli verilere kullanici degil de bizim icin erisme imkani
            //1. Getter ve Setter metotlari - Ogrenci
            //2. Property : Ozellik - Musteri
            
            Ogrenci o1 = new Ogrenci();
            Console.WriteLine("İsim: " + o1.getIsim()); //isim yok baslangicta bos
            o1.setIsim("Lain"); //bir isim yazdik
            Console.WriteLine("İsim: "+ o1.getIsim()); //yazilan isimi kaydetti.



            Musteri m1 = new Musteri();

            m1.KILO = 90; //deger atanirsa set
            Console.WriteLine("Kilo: "+m1.KILO); //deger atamasiz yazilirsa get bloklari calisir




            Console.ReadLine();

        }
    }
}
