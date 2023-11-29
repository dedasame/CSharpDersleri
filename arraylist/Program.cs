using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraylist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ARRAYLIST

            ArrayList liste = new ArrayList();
            liste.Add(1); //sona eleman ekler
            liste.Add("N4");   
            liste.Add('a');   
            liste.Add(4);
            liste.Add(4);

            liste.Remove(4); //ilk buldugu 4 degerini siler.

            Console.WriteLine(liste); //System.Collection.ArrayList

            Console.WriteLine("Listemizin eleman sayisi: "+ liste.Count); //eleman sayisi

            liste.Insert(2, "bes"); //istenilen index e elemani ekler ve diğer elemanlari kaydirir.

            liste.Reverse(); // ters cevirir.

            for (int i = 0; i < liste.Count; i++) 
            {
                Console.WriteLine(liste[i]);    
            }

            Console.WriteLine("Dizi icinde 'a' var mi? : "+ liste.Contains('a') ); // true: var false: yok

            Console.WriteLine("Dizi icindeki 'a' indexi: "+liste.IndexOf('a')); //0,1,2 ilk buldugu index 

            ArrayList sayilar = new ArrayList();

            sayilar.Add(63); 
            sayilar.Add(59);
            sayilar.Add(23);
            sayilar.Add(55);
            sayilar.Add(21);
            sayilar.Add(18);

            sayilar.Sort(); //kucukten buyuge siralar.

            foreach (int i in sayilar)
            {
                Console.Write(i + " ");

            }

            sayilar.ToString(); //stringe donusturur.


            liste.Clear(); //tum veriyi siler.






            Console.ReadLine();

        }
    }
}
