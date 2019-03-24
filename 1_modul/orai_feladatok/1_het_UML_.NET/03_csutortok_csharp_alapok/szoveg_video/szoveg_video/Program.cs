using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szoveg_video
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stringek formázása
            string name = "Yello";
            string strConcatenated = "Hello " + name + "!";

            double price = 2000;
            string priceFormattedOld = String.Format("Price = |{0, -20:C}| {1}", price, name); //{} között: placeholderek, 0, 1: sorszám, -20: 20 karakternyi hossz, balra igazítva, C: actual currency
            string priceFormattedNew = $"Price = |{price, 20:C}|";

            Console.WriteLine(priceFormattedOld);
            Console.WriteLine(priceFormattedNew);


            //Stringek összefűzése
            //konkatenálás
            string s = "Hello";
            s += " ";
            s += "Yellow!";
            Console.WriteLine(s);

            //StringBuilder
            StringBuilder sb = new StringBuilder("Hello");  //string Builder objektum létrehozása, megadás konstruktorban
            sb.Append(" ");
            sb.Append("Yellow!");
            string sNew = sb.ToString();
            Console.WriteLine(sNew);

            //Stringek összehasonlítása
            string s1 = "hali";
            //string s2 = "ha" + "li";
            string s2 = "HA" + "li";
            //if (s1 == s2)
            //if (s1.Equals(s2))   //string osztály metódusa - tartalom alapján dönti el, h azonos-e 
            //if (s1.ToLower().Equals(s2.ToLower()))
            if(string.Compare(s1, s2, true) == 0) //null értékű string változó is lehet, nem lesz exception
                //true: ignore case, nem tesz különbséget kis- és nagybetű között
                //int értéket ad vissza, nem bool-t!
            {
                Console.WriteLine("same");
            } else { 
                Console.WriteLine("not the same");
            }

            //Szöveg validálása - regex
            string textToTest = "012345678";
            string regularExpression = @"^\d{9}$"; //@:verbatim string ^ nem lehet előtte más karakter $: szöveg vége \d:decimális számjegy {9} darabszám
            bool result = Regex.IsMatch(textToTest, regularExpression);

            //string testThis = "123-4567";
            string testThis = "AB -4567";
            Console.WriteLine($"{testThis} is {(Regex.IsMatch(testThis, @"^\S{3}-?\d{4}$") ? "OK" :"not OK")}");
            testThis = "_A5 -4567";
            Console.WriteLine($"{testThis} is {(Regex.IsMatch(testThis, @"^\w{3}-?\d{4}$") ? "OK" : "not OK")}");
            testThis = "b111";
            Console.WriteLine($"{testThis} is {(Regex.IsMatch(testThis, @"^[a-z]\d{3}") ? "OK" : "not OK")}");
            testThis = "aza";
            Console.WriteLine($"{testThis} is {(Regex.IsMatch(testThis, @"^[az\d]{3}$") ? "OK" : "not OK")}");
            testThis = "Hello (xxxxx) nanana (just a comment)_(deleta all 122131) xxx (*omit this) Full stop";
            Console.WriteLine(Regex.Replace(testThis, @"\(.*?\)", ""));
            Console.WriteLine(Regex.Replace(testThis, "[(].*[)]", ""));
        }

    }
}
