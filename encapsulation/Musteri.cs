using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation
{
    public class Musteri
    {
        //prop double tab
        // get ve set yoksa ayni degisken gibi davranir.

        private int kilo;

        public int KILO
        {
            get
            {
                return kilo;
            }

            set 
            {
                //value : kullanicidan gelen deger -> kiloya atiyoruz.

                kilo = value;
            }
        }
    }
}
