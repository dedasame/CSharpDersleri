using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statiklik
{
    public class Personel
    {
        // STATIC METOT

        public void bilgi()
        {
            Console.WriteLine("Static olmayan metot!");
        }

        public static void staticbilgi()
        {
            Console.WriteLine("Static Metot Çalıştı!");
        }

        // STATIC DEGISKEN

        public int id { get; set; }
        public string isim { get; set; }
        public static int maas { get; set; } //sadece class üzerinden erişim var x objeden erişilmez.

        // STATIC CONSTRUCTOR

        private string kullaniciadi { get; set; }
        private int sifre { get; set; }
        private static int kod { get; set; } //static tanimlama -> static ctor icin.

                          //access modifiers: public private protected internal yok!
        static Personel() //parametre yok! 
        {                 //sadece 1 kere çalışır. kaç nesne olursa olsun.
            kod = 9613;
            
        }

        public Personel(string username,int password)
        {
            kullaniciadi = username;
            sifre = password;

        }

        public void gosterctor() 
        {
            Console.WriteLine("CTOR BİLGİLERİ");
            Console.WriteLine("USERNAME: "+ kullaniciadi);
            Console.WriteLine("PASSWORD: "+sifre);
            Console.WriteLine("CODE: "+kod);
        }


        public void yenikod(int x) 
        {
            Console.WriteLine("Yeni kod olusuyor...");
            kod += x;
            Console.WriteLine("YENİ KOD: " + kod);
        }





    }
}
