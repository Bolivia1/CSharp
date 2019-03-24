using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorNamespace
{

    public class Calculator
    {
        public Boolean Ellenorzes(int szam1, int szam2, string muveletiJel, int tipp) {           
            bool helyesATipp = false;
            int valosEredmeny = 0;

            switch (muveletiJel)
            {
                case "+":
                    valosEredmeny = szam1 + szam2;
                    break;

                case "-":
                    valosEredmeny = szam1 - szam2;
                    break;

                case "*":
                    valosEredmeny = szam1 * szam2;
                    break;

                case "/":
                    valosEredmeny = szam1 / szam2;
                    break;
            }

            
            if (tipp == valosEredmeny) {
                helyesATipp = true;
            }
            return helyesATipp;
        }
    }
}
