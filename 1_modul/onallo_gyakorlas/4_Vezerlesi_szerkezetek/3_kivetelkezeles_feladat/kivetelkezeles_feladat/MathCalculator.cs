using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kivetelkezeles_feladat
{
    public class MathCalculator
    {
        public double Calculate(int szam1, int szam2, string muveletiJel)
        {
            double eredmeny = 0;
            switch (muveletiJel)
            {
                case "+":
                    eredmeny = szam1 + szam2;
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
