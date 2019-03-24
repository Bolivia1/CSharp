using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace property_feladat
{
    public class BodyMass
    {
        /*2. BodyMass
        Egészítsd ki a BodyMass osztályt.

        Készíts Height és Weight property-t.Egyik se fogadjon el 0 vagy negatív értéket.
        A Height ne fogadjon el 280-nál nagyobb értéket sem.
        Alakítsd át a double GetBodyMassIndex() metódust double BodyMassIndex 
        read-only property-vé.*/

        private double bodyMassKg;
        private double bodyHeightM;
        private double bodyMassIndex;

        public double BodyMassKg    //Weight property
        {
            get { return bodyMassKg; }
            set {
                if(value>0) {
                    bodyMassKg=value;
                }
            }
        }
        public double BodyHeightM       //Height property
        {
            get { return bodyHeightM; }
            set {
                if(value>0 && value<2.8) {
                    bodyHeightM=value;
                }
            }
        }

        public double BodyMassIndex {
            get {
                bodyMassIndex=bodyMassKg/Math.Pow(bodyHeightM, 2);
                return bodyMassIndex;
            }
            private set { bodyMassIndex=value; }
        }



        public string GetBodyCategory() {
            string uzenet;
            if(bodyMassIndex<18.5) {
                uzenet="Sovány";
            } else if(bodyMassIndex>25) {
                uzenet="Túlsúlyos";
            } else {
                uzenet="Normál súlyú";
            }
            return uzenet;
        }

        /*bool IsThinnerThan(BodyMass): igazat ad, ha a példányom bmi-je kisebb,
         mint a paraméterként kapott példányé*/
        public bool IsThinnerThan(BodyMass masikEmber) {
            double bmi = this.BodyMassIndex;
            return bmi<masikEmber.BodyMassIndex;

        }
    }
}
