using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation
{
    public class Ogrenci
    {
        private string isim;

        public void setIsim(string isim_)
        {
            isim = isim_; //var olan degiskene gelen isim parametresini atiyoruz.
        }

        public string getIsim()
        {
            return isim;
        }



    }
}
