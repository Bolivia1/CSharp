using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace debuggoljunk_feladat
{
    class Program
    {
        /*Hozz létre egy új console projektet.Készíts egy Calculator 
         osztályt és benne egy Add metódust, ami megkap két int paramétert 
         és visszaadja a két paraméter összegét. A Main metódusból hívd meg 
         a Calculator osztály egy példányán keresztül az Add metódust. Hajtsd 
         végre a programot lépésenként.Vedd fel a két paraméter összegét, mint 
         kifejezést (x + y) a Watch ablakba.Figyeld a Locals, Autos ablakot is közben.*/

        static void Main(string[] args)
        {
            Calculator osszeadas = new Calculator();
            Console.WriteLine(osszeadas.Add(6, 9));
        }
    }
}
