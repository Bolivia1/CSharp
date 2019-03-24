using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halado_unit_teszteles_feladat
{
   /* 1. Teszt lefedettség

    Implementáld, hogy ha a SayHello metódus null paramétert kap, a visszaadott szöveg 
    Hello Anonymous legyen.Most már erre is kell írnod egy tesztmetódust, különben nem 
    lesz ez az ág lefedve.*/

    public class Gentleman
    {
        public string SayHello(string name)
        {
            string udvozles = String.Empty;
            if (name != null)
            {
                udvozles = "Hello " + name;
            }
            else {
                udvozles = "Hello Anonymus";
            }

            return udvozles;
        }

    }
}
