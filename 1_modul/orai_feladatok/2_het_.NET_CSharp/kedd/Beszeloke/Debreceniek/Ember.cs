using System;
using InterfacesLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Debreceniek
///Debreceniek hozzák létre az IBeszelokepes.cs interfészben definiált Beszélj() metódust 2 osztályban: Kutya és Ember
{
    public class Ember : IBeszlokepes   //interfész implementálása
    {
        public string Beszelj()     //az interfészben megadott metódus implementálása az Ember osztályban
        {
            string result = String.Empty;  //üres string
            result = "Jééé, tudok beszélni!";
            return result;
        }
    }
}
