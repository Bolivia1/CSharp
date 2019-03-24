using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace property_feladat
{
    class Book
    {
        private string szerzo;
        private string cim;
        private string regisztraciosSzam;

        public string Szerzo {
            get { return szerzo; }
            set { szerzo = value; }
        }

        public string Cim {
            get { return cim; }
            set { cim = value; }
        }

        public string RegisztraciosSzam
        {
            get { return regisztraciosSzam; }
            set { regisztraciosSzam = value; }
        }

        public void Register(String regNumber) {

        }

    }
}
