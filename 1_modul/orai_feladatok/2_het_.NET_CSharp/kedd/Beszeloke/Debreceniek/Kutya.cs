using InterfacesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Debreceniek   
 ///Debreceniek hozzák létre az IBeszelokepes.cs interfészben definiált Beszélj() metódust 2 osztályban: Kutya és Ember

{
    public class Kutya : IBeszlokepes  //interfész implementálása
    {
        public string Beszelj() //az interfészben megadott metódus implementálása a Kutya osztályban
        {
            return "Vauu, vau!";
        }
    }

   
}
