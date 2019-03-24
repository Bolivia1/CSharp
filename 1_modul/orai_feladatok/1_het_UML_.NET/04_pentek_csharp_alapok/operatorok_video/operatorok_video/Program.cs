using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatorok_video
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Adj meg egy számot, megmondom, páros-e! ");
            int number = int.Parse(Console.ReadLine());
            bool isEven = number % 2 == 0;
            if (isEven == true)
                Console.WriteLine("\nA(z) " + number + " szám páros.\n");
            else
                Console.WriteLine("\nA(z) " + number + " szám páratlan.\n");
            //isEven == true ? Console.WriteLine("A " + number + " szám páros.") : Console.WriteLine("A " + number + " szám páratlan.");

            int i = 7;
            int j = ++i;

            Console.WriteLine("i = " + i); //8
            Console.WriteLine("j = " + j + "\n"); //8

            int k = 7;
            int l = k++;

            Console.WriteLine("k = " + k); //7
            Console.WriteLine("l = " + l + "\n"); // 8*/

            //CompareDateTime();
            //ShowTheIsOperator();
            //LogicalOperators();
            //BitwiseOperators();
            Console.WriteLine("John"+4+4); //John44
            Console.WriteLine(4+4+"John");  //8John

            var typeInfo = typeof(Tanulo);
            var properties = typeInfo.GetProperties();
            Console.WriteLine(properties);

            Console.ReadKey();

        }

        private static void CompareDateTime() {
            DateTime birthdateOfBrian = new DateTime(2000, 10, 21);
            DateTime birthdateOfAnn = new DateTime(2010, 9, 24);

            if(birthdateOfBrian > birthdateOfAnn) {
                Console.WriteLine("Brian fiatalabb mint Ann.\n");
            } else if(birthdateOfBrian < birthdateOfAnn) {
                Console.WriteLine("Ann fiatalabb mint Brian.\n");
            } else { Console.WriteLine("Ugyanannyi idősek.\n"); }
        }

        private static void ShowTheIsOperator() {
            Tanulo brian = new Tanulo()
            {
                Nev = "Brian",
                szulDatum = new DateTime(2000, 10, 21)
            };

            Tanar maggie = new Tanar()
            {
                Nev = "Maggie",
                FoTantargy = "Történelem"
            };

            

            ArrayList resztvevok = new ArrayList();
            resztvevok.Add(brian);
            resztvevok.Add(maggie);

            foreach (var resztvevo in resztvevok) {
                /* if (resztvevo is Tanulo)  {  //is: megvizsgálja, ha a résztvevő Tanulo típusú-e
                     ((Tanulo)resztvevo).Jatszik(); //konvertálás típuskényszerítéssel - hibát dobhat, ha nem Tanulo típusú a résztvevő
                     } else {
                     (resztvevo as Tanar).KavetIszik();
                     } 
                 //típuskényszerítés as operátorral  csak referencia típusokra     */

                var tanulo = resztvevo as Tanulo;  //ha nem Tanulo: null érték, nem hiba
                if(tanulo != null) {
                    tanulo.Jatszik();
                } else {
                    var tanar = resztvevo as Tanar;
                    if(tanar != null) {
                        tanar.KavetIszik();
                    }
                }
            }
        }

        private static void LogicalOperators() {
            bool x = true;
            bool y = false;
            bool logicalResult = x & y;
            Console.WriteLine($"{x} & {y} = {logicalResult}");

            logicalResult = x | y;
            Console.WriteLine($"{x} | {y} = {logicalResult}");

            logicalResult = x ^ y;
            Console.WriteLine($"{x} ^ {y} = {logicalResult}");

            logicalResult = !x;
            Console.WriteLine($"!{x} = {logicalResult}");
        }

        private static void BitwiseOperators() {
            int a = 3;
            int b = 9;
            Console.WriteLine($"{a:x8}");
            Console.WriteLine($"a={Convert.ToString(a, 2)}"); //2-es számrendszerbe Convert.ToString-gel
            Console.WriteLine($"b={Convert.ToString(b, 2)}");

            Console.WriteLine("Result: ");
            //var result = a & b;
            //var result = a | b;
            //var result = a ^ b;
            var result = ~a; //uint!  minden bitet átformál
            Console.WriteLine($"Decimális: {result}");
            Console.WriteLine($"Hexa: {result:x8}");
            Console.WriteLine($"Binary: {Convert.ToString(result, 2)}");

        }
    }
}
