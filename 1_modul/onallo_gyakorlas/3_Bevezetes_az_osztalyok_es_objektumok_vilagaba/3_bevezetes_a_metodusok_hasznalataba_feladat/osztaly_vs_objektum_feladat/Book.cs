using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bevezetes_a_metodusok_hasznalataba_feladat
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

        /*2. Könyv osztály

        Bővítsd a Book osztályt.Legyen egy public void Register(String regNumber) 
        metódusa, mely a nyilvántartásba vétel, és ennek paraméterként meg kell adni
        a regisztrációs számot.*/
        public void Register(String regNumber) {

        }

    }
}
