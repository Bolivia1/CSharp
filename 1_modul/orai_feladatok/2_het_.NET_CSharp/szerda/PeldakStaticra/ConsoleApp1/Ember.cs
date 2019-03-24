using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Ember
    {
        private static int letrehozottEmberekSzama = 0; //osztályszintű
        private string neve;  //objektumszintű

        public Ember(string neve)      //konstruktor visszatérési értéke: az adott típusnak megfelelő objektum
        {                              //objektumszintű tag: típuson belül érjük el
            letrehozottEmberekSzama++;
            this.neve = neve;
        }

        public string Neve  // objektumszintű tagváltozó értékének lekérdezése, beállítása
        {
            get { return this.neve; }   //történhet a this kulcsszóval
            set { this.neve = value; }
        }

        public static int LetrehozottEmberekSzama { //this: objektum saját magára mutat, nem érhető el az osztályszintű változó
            get { return letrehozottEmberekSzama;
            }
            private set { letrehozottEmberekSzama = value; }
        }
    }
}
