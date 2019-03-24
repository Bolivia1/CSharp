using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace property_feladat
{
   /* 1. Kávé osztály
    Készíts egy Coffee osztályt.Vegyél fel benne néhány property-t:
    Name (string)
    Strength (int): csak 0 és 10 közötti értéket fogadjon el.
    CountryOfOrigin (string)*/

    class Coffee
    {
        private int strength;

        public string Name { get; set; }
        public int Strength {
            get { return strength; }
            set { if (value >=0 && value <=10) { value = strength; }
            }
        }
        public string CountryOfOrigin { get; set; }
    }
}
