using System;
using Debreceniek;
using InterfacesLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Budapestiek   //a budapestiek hívják meg a debreceniek által létrehozott osztályokat
{
    class Program
    {
        static void Main(string[] args)
        {
            Ember imi = new Ember();    //új példány létrehozása az osztályból
            Console.WriteLine(imi.Beszelj());    //Példányon Beszélj() metódus meghívása        

            Kutya bodri = new Kutya();
            Console.WriteLine(bodri.Beszelj());

            IBeszlokepes[] beszelokepesObjektumok = new IBeszlokepes[2];  //közös tulajdonság - ilyen típusú tömb definiálása 
            beszelokepesObjektumok[0] = imi;    //tömb elemeinek felvétele
            beszelokepesObjektumok[1] = bodri;

            for (int i = 0; i < beszelokepesObjektumok.Length; i++)
            {
                Console.WriteLine(beszelokepesObjektumok[i].Beszelj()); //tömb elemein metódus meghívása
            }

            Console.ReadKey(); //ablak ottmaradjon
        }
    }
}
