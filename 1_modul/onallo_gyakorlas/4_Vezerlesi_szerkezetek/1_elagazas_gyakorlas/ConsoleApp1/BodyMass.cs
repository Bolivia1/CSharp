using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elagazas_gyakorlas
{
    /* 3. BodyMass

        Egészítsd ki a BodyMass osztályt. Készíts egy string BodyCategory read-only 
        property-t, ami visszaadja a testalkatot:
        ha a bmi (bodymassindex) < 18.5, akkor "UnderWeight"
        ha bmi > 25, akkor "OverWeight"
        különben "Normal"*/

    public class BodyMass
    {
        private double bodyMassKg;
        private double bodyHeightM;
        private double bodyMassIndex;
        private string bodyCategory;


        public double BodyMassKg
        {
            get { return bodyMassKg; }
            set
            {
                if (value > 0)
                { bodyMassKg = value; }
            }
        }
        public double BodyHeightM
        {
            get { return bodyHeightM; }
            set
            {
                if (value > 0 && value < 2.8)
                { bodyHeightM = value; }
            }
        }

        public double BodyMassIndex
        {
            get
            {
                bodyMassIndex = bodyMassKg / Math.Pow(bodyHeightM, 2);
                return bodyMassIndex;
            }
            private set { bodyMassIndex = value; }
        }


        public string GetBodyCategory()
        {
            string uzenet;
            if (bodyMassIndex < 18.5)
            {
                uzenet = "Sovány";
            }
            else if (bodyMassIndex > 25)
            {
                uzenet = "Túlsúlyos";
            }
            else
            {
                uzenet = "Normál súlyú";
            }
            return uzenet;
        }

        public bool IsThinnerThan(double testTomeg, double magassag)
        {
            BodyMass testTomegIndex = new BodyMass();
            double masikBmi = testTomeg / Math.Pow(magassag, 2);

            Console.Write("Adja meg a testsúlyát kg-ban! ");
            testTomegIndex.BodyMassKg = int.Parse(Console.ReadLine());

            Console.Write("Adja meg a magasságát m-ben! ");
            testTomegIndex.BodyHeightM = int.Parse(Console.ReadLine());


            double testTomegIndexSzamitas = testTomegIndex.BodyMassIndex;
            return testTomegIndexSzamitas / masikBmi < 1;

        }

        /* 3. BodyMass

        Egészítsd ki a BodyMass osztályt. Készíts egy string BodyCategory read-only 
        property-t, ami visszaadja a testalkatot:
        ha a bmi (bodymassindex) < 18.5, akkor "UnderWeight"
        ha bmi > 25, akkor "OverWeight"
        különben "Normal"*/

        public string BodyCategory
        {
            get
            {
                if (bodyMassIndex < 18.5) {bodyCategory = "UnderWeight"; }
                else if (bodyMassIndex >= 18.5 && bodyMassIndex < 25) {bodyCategory = "Normal";}
                else {bodyCategory = "OverWeight";}
                return bodyCategory;
            }
            private set {bodyCategory = value;}
        }
    }
}
