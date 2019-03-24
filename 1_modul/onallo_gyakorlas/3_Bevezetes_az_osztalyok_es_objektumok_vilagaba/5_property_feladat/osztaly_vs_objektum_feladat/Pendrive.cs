using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace property_feladat
{
    class Pendrive
    /*3. Pendrive osztály
    Egészítsd ki a Pendrive osztályt.Készíts az adattagokhoz property-ket.
    A kapacitás és az ár nem lehet 0 vagy negatív.*/

    {
        private string name;
        private int capacity;
        private int price;

        public string Name {
            get { return name; }
            set { name=value; }
        }

        public int Capacity {
            get { return capacity; }
            set {
                if(capacity>0) {
                    capacity=value;
                }
            }
        }

        public int Price {
            get { return price; }
            set {
                if(price>0) {
                    price=value;
                }
            }
        }

        public override string ToString() {
            return name+" "+capacity+" "+price;
        }

        public void IncreasePrice(int percent) {
            price=price*(1+percent/100);
        }

        public int ComparePricePerCapacity(Pendrive masikPendrive) {
            if(price>masikPendrive.price||capacity>masikPendrive.capacity) {
                return 1;
            } else if(price==masikPendrive.price||capacity==masikPendrive.capacity) {
                return 0;
            } else {
                return -1;
            }
        }

        public bool IsCheaperThan(Pendrive masikPendrive) {
            return price<masikPendrive.price;
        }
    }
}
