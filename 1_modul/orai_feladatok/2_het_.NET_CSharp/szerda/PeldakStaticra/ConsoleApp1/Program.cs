using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        private static string s = "Hello world!";   //statikus metóduson belül csak statikus tagváltozó tudunk elérni


        public static void Main(string[] args)
        {
            Console.WriteLine(s);
            Console.WriteLine(Helloka("Oli"));

            Console.WriteLine(Ember.LetrehozottEmberekSzama);
            Ember imi1 = new Ember("Ubul");
            Console.WriteLine(imi1.Neve); //Ubul

            Console.WriteLine(Ember.LetrehozottEmberekSzama);
            Ember imi2 = new Ember("Béla");
            Console.WriteLine(imi2.Neve);  //Béla

            Console.WriteLine(Ember.LetrehozottEmberekSzama);
            Ember imi3 = new Ember("Mari");  //new mögött: konstruktor fv

            Console.WriteLine(Ember.LetrehozottEmberekSzama);

            Console.WriteLine(imi3.Neve);
            imi3.Neve = "Béláné";

            Console.WriteLine(imi3.Neve);

            Console.ReadKey();
        }

        private static string Helloka(string neved) {
            return "Szia " + neved;
        }
    }
}
