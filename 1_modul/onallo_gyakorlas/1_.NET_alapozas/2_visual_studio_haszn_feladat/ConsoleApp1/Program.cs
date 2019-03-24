using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToVS
{
    class Program
    {
        static void Main(string[] args)
        {
           /* 2.Új projekt
            Hozz létre egy új konzol alkalmazást IntroToVS néven, mely kiírja a Hello World!szöveget.
            Futtasd az alkalmazást.*/

            Console.WriteLine("Hello World!");

            /* 3.Projekt megnyitása
            Nyisd meg az IntroToVS.sln solution-t.A Program.cs állományban írd át az üdvözlő 
            szöveget Hello Yello!szövegre.Indítsd el a programot!*/

            Console.WriteLine("Hello Yello!");

            /*4.Új sor

            Egészítsd ki a programot plusz egy sor kiírásával, mely kiírja az 
            átadott paraméterek számát. Használd a cw code snippet - et.*/

           Console.WriteLine(args.Length+" db argumentum");/*argumentumok megadása: projekten jobb klick, properties, 
            debug + command line arguments => csak debugolásra, egyébként: parancssor*/            
            for (int i = 0; i < args.Length; i++)
            { 
                Console.WriteLine(args[i]);
            }

            Console.ReadKey();

        }
    }
}
