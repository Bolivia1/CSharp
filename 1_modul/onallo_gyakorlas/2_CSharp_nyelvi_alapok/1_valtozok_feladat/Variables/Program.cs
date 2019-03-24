using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
      
       /* private static bool b;
        private static int a = 2;
        private static int x = 3, y = 4;
        private static int k = x;
        private static string s = "Hello World";*/

        public static void Main(string[] args)
        {
            /* 1. Logikai változó
            Hozz létre egy konzol alkalmazást Variables néven.
            A Main metódusban deklarálj egy bool típusú változót b néven, majd írasd ki az értékét.
            Adj értékül neki false értéket.*/

            bool b = false;
            Console.WriteLine(b);

            /* 2.Egész változó

            Deklarálj egy int típusú változót 2 kezdőértékkel a néven.
            Deklarálj egy sorban két int típusú változót x és y néven, 3 és 4 kezdőértékkel.
            Deklarálj egy int típusú változót k néven, és add neki értékül az x változó értékét.
            Próbálj egy változót deklarálása előtt kiírni. Sikerül?*/
            int a = 2;
           // Console.WriteLine(x);
            int x = 3, y = 4;
            int k = x;


            /*3.Szöveges változó

            Deklarálj egy string típusú változót s néven.Adj neki "Hello World" értéket!
            Deklarálj egy string típusú változót t néven, és add értékül neki az s változó értékét!
            Metóduson belül deklarálj egy blokkot(kapcsos zárójelek között).
            A blokkon belül deklarálj egy int típusú x változót 0 kezdőértékkel.
            Az értékét próbáld kiírni a blokk után, a blokkon kívül.Fog sikerülni?
            A blokkban próbáld meg kiírni a blokkon kívül, a blokk előtt definiált a változó értékét.*/

            string s = "Hello World";
            string t = s;
            
            /*Console.WriteLine(b);
            fx();
            Console.WriteLine(x);
            Console.WriteLine(a);
            Console.ReadLine();*/
            Console.WriteLine(UInt64.MaxValue);
            Console.ReadLine();
        }

        static void fx()
        {
            int x = 0;
            bool b = false;
            Console.WriteLine(x);
            Console.WriteLine(a);
            Console.ReadLine();
        }
        
    }
}
