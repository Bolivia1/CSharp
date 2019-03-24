using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_feladat
{
    class Program
    {
        static void Main(string[] args)
        { //1. Összefűzés
            string lit1 = "Ez az első string literál. ";
            string lit2 = "Ez a második string literál.";
            string result = lit1 + lit2;
            Console.WriteLine(result);

            StringBuilder sb = new StringBuilder("Ez az első string literál.");
            sb.Append(" ");
            sb.Append("Ez a második string literál.");
            string newResult = sb.ToString();
            Console.WriteLine(newResult);

            //2. String mint objektum
            string titleUpper = "title".ToUpper();
            Console.WriteLine(titleUpper);

            //3. Formázz!
            int amountBefore = 2000;
            int amountAfter = 1500;
            string koltottOsszeg = $"Összesen {amountBefore - amountAfter,7:C} -ot költöttél.";
            Console.WriteLine(koltottOsszeg);
            Console.ReadKey();
        }
    }
}
