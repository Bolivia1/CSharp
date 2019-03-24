using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elagazas_gyakorlas
{
    /*4. Egy kis matematika
        A MathCalculator osztályban írj egy Calculate nevű metódust, 
        mely paraméterként kap két számot, valamint egy műveleti jelet('+', '-', '*', '/') 
        és visszaadja a két számon elvégzett matematikai művelet eredményét.*/

    class MathCalculator
    {
        public double Calculate(double szam1, double szam2, string muveletiJel) {
            double eredmeny = 0;
            switch (muveletiJel)
            {
                case "+": eredmeny = szam1 + szam2;
                    break;
                case "-":
                    eredmeny = szam1 - szam2;
                    break;
                case "*":
                    eredmeny = szam1 * szam2;
                    break;
                case "/":
                    eredmeny = szam1 / szam2;
                    break;
            }
            return eredmeny;
        }
    }
}
