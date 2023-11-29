using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    public class Araba
    {
        public int kapiSayisi;
        public string model;
        public string renk;


        //Constructor Metot: geri donus tipi yok - ayni class ismi
        //ctor + double tab

        public Araba(int kapi_sayisi,string model_,string renk_)
        {
            kapiSayisi = kapi_sayisi; //var olan degiskenlere gelen degiskenkleri atiyoruz.
            model = model_;
            renk = renk_;

        }

        public void motorcalistir()
        {
            Console.WriteLine("Arabamiz calisti Model: " + model); 

        }

        public void arabayikilitle()
        {
            Console.WriteLine("Arabamiz kilitlendi Model: " + model);

        }



    }
}
