using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alistirma
{
    internal class Personel
    {
        private string tckimlikno;

        public string TCNO 
        {
            get 
            {

                return tckimlikno.Substring(0,5); //Substring: 0. indexten basla + 5 karakter uzunlugunda kelime ver

            }
            set 
            {
                bool kontrol = false;
                if(value.Length == 11) //string ifadenin uzunlugunu kontrol eder.
                {
                    for (int i = 0; i < value.Length; i++) 
                    {
                        kontrol = char.IsNumber(value[i]); //isNumber: sayi ise true, karakter ise false
                        if (!kontrol) //karakter olup false donderse devam etmeye gerek kalmaz. kontrol degiskenimizi false yapar ve break ile donguden cikariz
                        {
                            kontrol = false;
                            break;
                        }
                        else //kontrol degiskenimiz true olarak donmeye devam eder
                        {
                            kontrol = true;
                        }
                    }

                    //donguden ciktiktan sonra:
                    if (kontrol == true) //kontrol true ise tc dogru yazilmis kayit ederiz.
                    {
                        tckimlikno = value;
                    }
                    else //uyari veririz hatali tc
                    {
                        Console.WriteLine("TC Kimlik No Karakter İçeremez.");
                    }
                    
                }

                else
                {
                    Console.WriteLine("Girdiginiz TC Kimlik No 11 Karakter değil.");
                }
            
            } 
        
        }

    }
}
