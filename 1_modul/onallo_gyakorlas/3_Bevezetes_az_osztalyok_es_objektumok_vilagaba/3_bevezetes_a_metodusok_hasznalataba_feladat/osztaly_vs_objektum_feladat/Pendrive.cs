using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bevezetes_a_metodusok_hasznalataba_feladat
{

    /* 4. Pendrive osztály

     Készíts egy Pendrive osztályt.A Pendrive tagjai:

     Adattagjai: name, capacity, price.
     A kapacitás egész szám GB-ben megadott érték.
     Az ár egész szám forintban megadott érték.

     Legyen string ToString() metódusa, amely egy Stringbe összefűzve 
     adja vissza a pendrive adatait.

     Legyen void IncreasePrice(int percent) metódusa, amely megadott 
     százalékkal megemeli a pendrive árát.

     Legyen `int ComparePricePerCapacity(Pendrive)` metódusa, amely 
     összehasonlítja a példányt egy paraméterként kapott másik példánnyal 
     az ár/kapacitás alapján. Az eredmény legyen
     1, ha az aktuális példány ár/kapacitása nagyobb,
     -1, ha a paraméterként kapott példányé nagyobb,
     0, ha egyformák.

     Legyen egy bool IsCheaperThan(Pendrive) metódusa, amely igazat ad, 
     ha a példány ára kisebb, mint a paraméterben kapott példány ára.*/

    class Pendrive
    {
        /*Adattagjai: name, capacity, price.
        A kapacitás egész szám GB-ben megadott érték.
        Az ár egész szám forintban megadott érték.*/
        private string name;
        private int capacity;
        private int price;

        public string Name {
            get { return name; }
            set { name=value; }
        }

        public int Capacity {
            get { return capacity; }
            set { capacity=value; }
        }

        public int Price {
            get { return price; }
            set { price=value; }
        }

        /*Legyen string ToString() metódusa, amely egy Stringbe összefűzve
           adja vissza a pendrive adatait.*/
        public override string ToString() {
            return name+" "+capacity+" "+price;
        }

        /*Legyen void IncreasePrice(int percent) metódusa, amely megadott
           százalékkal megemeli a pendrive árát.*/
        public void IncreasePrice(int percent) {
            Console.WriteLine($"Az új ár: {(1+((double)percent/100))*price}");
        }

        /*Legyen `int ComparePricePerCapacity(Pendrive)` metódusa, amely
        összehasonlítja a példányt egy paraméterként kapott másik példánnyal
        az ár/kapacitás alapján.Az eredmény legyen
        1, ha az aktuális példány ár/kapacitása nagyobb,
        -1, ha a paraméterként kapott példányé nagyobb,
         0, ha egyformák.*/
        public int ComparePricePerCapacity(Pendrive masikPendrive) {
            if(price>masikPendrive.price||capacity>masikPendrive.capacity) {
                return 1;
            } else if(price==masikPendrive.price||capacity==masikPendrive.capacity) {
                return 0;
            } else {
                return -1;
            }
        }

        /*Legyen egy bool IsCheaperThan(Pendrive) metódusa, amely igazat ad, 
        ha a példány ára kisebb, mint a paraméterben kapott példány ára.*/
        public bool IsCheaperThan(Pendrive masikPendrive) {
            return price<masikPendrive.price;

        }
    }
}
