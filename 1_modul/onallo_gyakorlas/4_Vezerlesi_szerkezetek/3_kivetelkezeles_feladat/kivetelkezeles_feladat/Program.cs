using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kivetelkezeles_feladat
{
    class Program
    {
        static void Main(string[] args) {
            Class1.BirkaImi();

            MonthHandler evEsHonap = new MonthHandler();
            try { evEsHonap.GetDaysOfMonthInYear(2000, "jun"); }
            catch(ArgumentException ex) {
                Console.WriteLine(ex.Message);
            }


            MathCalculator muvelet = new MathCalculator();
            try {
                Console.WriteLine(muvelet.Calculate(10, 0, "/"));
            }
            catch(DivideByZeroException) { Console.WriteLine("Nullával nem lehet osztani."); }


            Console.WriteLine(CalculateMeterReadingsDifference(9905, 9999));

            try {
                Patient beteg = new Patient {
                    YearOfBirth=1899,
                    SocialSecurityNumber="246xy4689"
                };
                Console.WriteLine(beteg.YearOfBirth);
                Console.WriteLine(beteg.SocialSecurityNumber);
            }
            catch(ArgumentException ex) {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();

        }

        /*1. Villanyóra állás

        A public int CalculateMeterReadingsDifference(int prev, int next) metódusban 
        számold ki a paraméterként megadott mérőóraállás közötti különbséget. 
        Ha 9999 értéknél nagyobbat kap paraméterül, akkor dobjon kivételt.*/

        public static int CalculateMeterReadingsDifference(int prev, int next) {
            int meroallasokKulonbsege = 0;
            if(prev>9999||next>9999) {
                throw new ArgumentOutOfRangeException("A megadott értékeknek 10.000 alatt kell lenniük.");
            }
            meroallasokKulonbsege=next-prev;
            return meroallasokKulonbsege;
        }

        /*2. Hónap napjainak visszaadása
         
        A MonthHandler osztályban írj egy olyan metódust, 
        mely az év és a hónap magyar neve alapján visszaadja, hogy 
        az hány napos, a metódus neve GetDaysOfMonthInYear legyen. 
        Használj switch szerkezetet. Figyelj arra, hogy ne számítson a 
        kis- és nagybetű különbség. Ha nem ismert a hónap, dobj kivételt!

        Figyelj a szökőévre (év osztható néggyel, de nem osztható százzal, 
        kivéve, ha osztható 400-zal).*/

        /*3. Egy kis matematika
        
        Mi történik, ha a MathCalculator osztály Calculate metódusát 
        meghívjuk(10, 0, '/') argumentumokkal?*/

        /*4. Rendelő

        Hozz létre egy Patient osztályt, a szükséges adatokkal:

        Name, a beteg neve
        SocialSecurityNumber, a beteg TAJ száma(string-ként tárolva, 
        hiszen 0-val is kezdődhet!)
        YearOfBirth, a beteg születési éve
        Ellenőrizd a születési évet és csak akkor fogadd el, 
        ha legalább 1900.ArgumentOutOfRangeException dobásával jelezd a 
        nem megfelelő értékeket.

        Ellenőrizd a TAJ számot is a következő algoritmussal: A TAJ szám 
        egy kilenc számjegyből álló szám.A TAJ szám első nyolc számjegyéből a 
        páratlan helyen állókat hárommal, a páros helyen állókat héttel szorozzuk, 
        és a szorzatokat összeadjuk. Az összeget tízzel elosztva a maradékot tekintjük 
        a kilencedik, azaz ellenőrző kódnak.Ha az ellenőrző kód nem egyezik, 
        akkor ne fogadd el a TAJ számot.
        ArgumentException dobásával jelezd a nem megfelelő értékeket.*/

    }
}
