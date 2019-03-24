using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kifejezesek_operatorok_feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Miért?
            Console.WriteLine("John"+4+4);  //John44
            Console.WriteLine(4+4+"John");  //8John

            //2.Definiálj
            int x = 5 + 6;
            int y = 11 - x;
            int z = 8;
            bool b = x > y ? true : false;
            bool c = b == true || z > 5 ? true : false;
            z++;
            Console.WriteLine("x="+ x +" y=" + y + " z=" + z + " b=" + b + " c=" + c +"\n");

            //3. Átváltások
            Console.Write("Add meg a hőmérsékletet °C-ban! ");
            int homerseklet = int.Parse((Console.ReadLine()));
            Console.WriteLine($"\nA megadott hőmérséklet Fahrenheitben:{homerseklet * 1.8 + 32}F");
            Console.WriteLine($"A megadott hőmérséklet Kelvinben: {homerseklet + 273.15} K\n");

            //4. Szökőév
            Console.Write("Adj meg egy évszámot! ");
            int megadottEv = int.Parse((Console.ReadLine()));

            string uzenet = (megadottEv % 4 == 0 && megadottEv % 100 != 0) || megadottEv % 400 == 0 ? $"A {megadottEv} év szökőév." : $"A {megadottEv} év nem szökőév.";
            Console.WriteLine(uzenet);
            Console.ReadKey();

        

        }
    }
}
