using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kivetelkezeles_feladat
{
    class MonthHandler
    {
        /*2. A MonthHandler osztályban írj egy olyan metódust, 
        mely az év és a hónap magyar neve alapján visszaadja, hogy 
        az hány napos, a metódus neve GetDaysOfMonthInYear legyen. 
        Használj switch szerkezetet. Figyelj arra, hogy ne számítson a 
        kis- és nagybetű különbség. Ha nem ismert a hónap, dobj kivételt!

        Figyelj a szökőévre (év osztható néggyel, de nem osztható százzal, 
        kivéve, ha osztható 400-zal).*/

        public void GetDaysOfMonthInYear(int ev, string honap)
        {
            string evTipusa = ev % 4 == 0 && ev % 100 != 0 || ev % 400 == 0 ? "szokoev" : "nemSzokoev";
            int honapNapjainakSzama = 0;
            
            switch (evTipusa + honap.ToLower())
            {
                case "nemSzokoev" + "január":
                case "nemSzokoev" + "március":
                case "nemSzokoev" + "május":
                case "nemSzokoev" + "július":
                case "nemSzokoev" + "augusztus":
                case "nemSzokoev" + "október":
                case "nemSzokoev" + "december":

                case "szokoev" + "január":
                case "szokoev" + "március":
                case "szokoev" + "május":
                case "szokoev" + "július":
                case "szokoev" + "augusztus":
                case "szokoev" + "október":
                case "szokoev" + "december":
                    honapNapjainakSzama = 31;
                    break;

                case "nemSzokoev" + "április":
                case "nemSzokoev" + "június":
                case "nemSzokoev" + "szeptember":
                case "nemSzokoev" + "november":

                case "szokoev" + "április":
                case "szokoev" + "június":
                case "szokoev" + "szeptember":
                case "szokoev" + "november":
                    honapNapjainakSzama = 30;
                    break;

                case "nemSzokoev" + "február":
                    honapNapjainakSzama = 28;
                    break;

                case "szokoev" + "február":
                    honapNapjainakSzama = 29;
                    break;

                default:
                    throw new ArgumentException("Ismeretlen hónap");
            }
            Console.WriteLine($"{ev} év {honap} hónap napjainak száma: {honapNapjainakSzama}");
           
        }

    }
}
