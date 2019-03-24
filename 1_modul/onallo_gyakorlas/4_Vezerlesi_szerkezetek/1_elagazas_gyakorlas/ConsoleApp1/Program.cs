using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elagazas_gyakorlas
{
    public class Program
    {
        private static string s = "Szia Oli";
        public static void Main(string[] args) {
            Console.WriteLine(Koszonto(8, 15));
            Console.WriteLine(s);
            Console.WriteLine(CalculateMeterReadingsDifference(9990, 7));

            BodyMass oli = new BodyMass {
                BodyMassKg=58,
                BodyHeightM = 1.74,
            };
            Console.WriteLine(oli.BodyMassIndex);
            Console.WriteLine(oli.BodyCategory);
            

            MathCalculator szamitas = new MathCalculator();
            Console.WriteLine(szamitas.Calculate(5, 8, "/"));


            LetterManager mshg = new LetterManager();
            Console.WriteLine(mshg.SkipIfVowel('e'));

            LetterManager ekezet = new LetterManager();
            Console.WriteLine(ekezet.ChangeIfHungarianStrangeLetter('ö'));

            Console.ReadKey();
        }

        /*1. Napszaktól függő köszönés
        Írj egy metódust, mely paraméterként megkapja az órát és a percet, 
        és amennyiben 5:00 után van, köszönjön jó reggelt, 9:00 és 18:30 között 
        jó napot, 20:00-ig jó estét, majd jó éjt.*/

        public static string Koszonto(int ora, int perc) {

            int idoPercben = ora*60+perc;
            string koszontes;

            if(idoPercben>=300&&idoPercben<540) {
                koszontes="Jó reggelt!";

            } else if(idoPercben>=540&&idoPercben<1110) {
                koszontes="Jó napot!";

            } else if(idoPercben>=1110&&idoPercben<1200) {
                koszontes="Jó estét!";

            } else {
                koszontes="Jó éjszakát!";

            }
            return koszontes;
        }


        /*2. Villanyóra állás

        A public int CalculateMeterReadingsDifference(int prev, int next) metódusban 
        számold ki a paraméterként megadott mérőóraállás közötti különbséget. Ha a 
        villanyóra eléri a 9999 értéket, átfordul, és újraindul 0 értéktől.Tételezzük fel, 
        hogy csak egyszer fordulhat át, és nem érheti el az előző értéket.Tételezzük fel, 
        hogy 9999 értéknél nagyobbat nem kap paraméterül.*/

        public static int CalculateMeterReadingsDifference(int prev, int next) {
            int meroallasokKulonbsege = 0;

            if(next<=9999 && next>prev) {
                meroallasokKulonbsege=next-prev;

            } else if(prev<=9999 && next<prev) {
                meroallasokKulonbsege=9999-prev+next;

            }

            return meroallasokKulonbsege;
        }

        /* 3. BodyMass

         Egészítsd ki a BodyMass osztályt. Készíts egy string BodyCategory read-only 
         property-t, ami visszaadja a testalkatot:
         ha a bmi (bodymassindex) < 18.5, akkor "UnderWeight"
         ha bmi > 25, akkor "OverWeight"
         különben "Normal"*/


        /*4. Egy kis matematika

        A MathCalculator osztályban írj egy Calculate nevű metódust, 
        mely paraméterként kap két számot, valamint egy műveleti jelet('+', '-', '*', '/') 
        és visszaadja a két számon elvégzett matematikai művelet eredményét.*/


        /*5. Magánhangzó
          
        A LetterManager oszályban írj egy SkipIfVowel metódust, mely kap egy 
        karakter paramétert. Amennyiben magánhangzót kap, a következő mássalhangzót 
        adja vissza.Ha mássalhangzót kap, akkor a mássalhangzót adja vissza. Elég, 
        ha az angol ábécé karaktereivel működik.*/

    }
}
