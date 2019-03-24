using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bevezetes_a_metodusok_hasznalataba_feladat
{

    /*3. BodyMass osztály

    Készíts egy BodyMass osztályt, amely testtömegindexet számol.
    Adatai: tömeg (kilogrammban megadva), magasság (méterben megadva).

    Publikus metódusai:

    double GetBodyMassIndex(): visszaadja a testtömegindexet, 
    használja a következő képletet: tömeg osztva a magasság négyzetével.

    string GetBodyCategory(): visszaadja a testalkatot:
    ha a bmi (bodymassindex) < 18.5, akkor "UnderWeight"
    ha bmi > 25, akkor "OverWeight"
    különben "Normal"

    bool IsThinnerThan(BodyMass): igazat ad, ha a példányom bmi-je kisebb, 
    mint a paraméterként kapott példányé*/
    class BodyMass
    {
        
        public double BodyMassKg {get; set;}
        public double BodyHeightM {get; set;}

        /*double GetBodyMassIndex(): visszaadja a testtömegindexet, 
        használja a következő képletet: tömeg osztva a magasság négyzetével.*/
        public double GetBodyMassIndex() {
            return BodyMassKg / Math.Pow(BodyHeightM, 2);
        }
        /*string GetBodyCategory(): visszaadja a testalkatot:
        ha a bmi(bodymassindex) < 18.5, akkor "UnderWeight"
        ha bmi > 25, akkor "OverWeight"
        különben "Normal"*/
        public string GetBodyCategory() {
            double bmi = GetBodyMassIndex();
            string uzenet;
            if (bmi < 18.5) {
                uzenet = "Sovány";
            } else if(bmi>25) {
                uzenet = "Túlsúlyos";
            } else {
                uzenet = "Normál súlyú";
            }
            return uzenet;
        }
       

        /*bool IsThinnerThan(BodyMass): igazat ad, ha a példányom bmi-je kisebb,
          mint a paraméterként kapott példányé*/
        public bool IsThinnerThan(BodyMass masikEmber) {
            double bmi = GetBodyMassIndex();
            return bmi < masikEmber.GetBodyMassIndex();

        }
    }
}
