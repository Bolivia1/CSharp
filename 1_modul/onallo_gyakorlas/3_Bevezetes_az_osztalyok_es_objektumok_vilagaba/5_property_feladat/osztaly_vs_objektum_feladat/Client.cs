using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace property_feladat
{
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
