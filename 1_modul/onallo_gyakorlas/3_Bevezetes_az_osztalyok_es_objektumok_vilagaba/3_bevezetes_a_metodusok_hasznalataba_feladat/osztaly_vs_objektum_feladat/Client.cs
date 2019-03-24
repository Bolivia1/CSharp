using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yellowroad
{
    /* 1. Ügyfél osztály
        Bővítsd a Client osztályt.Legyen egy public void Move(String) metódusa, 
        mely az ügyfél elköltözését implementálja, valójában beállítja a címet 
        az új, paraméterként átadott címre.*/
    class Client
    {
        private string name;
        private DateTime birthday;
        private string address;

        public string Name {
            get { return name; }
            set { name = value; } 
        }

        public DateTime Birthday {
            get { return birthday; }
            private set { birthday = value; }
        }

        public string Address {
            get { return address; }
            private set { address = value; }
        }

        public void Move(String ujCim)
        {
            address = ujCim;
        }

    }
}
