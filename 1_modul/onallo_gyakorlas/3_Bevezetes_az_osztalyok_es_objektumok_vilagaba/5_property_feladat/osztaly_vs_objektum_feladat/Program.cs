using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace property_feladat
{
    class Program
    {
        public static void Main(string[] args)
        {
            BodyMass oli = new BodyMass();
            oli.BodyMassKg=58d;
            oli.BodyHeightM=1.74;
            Console.WriteLine(oli.BodyMassIndex);

            BodyMass valakiMas = new BodyMass();
            valakiMas.BodyMassKg=80d;
            valakiMas.BodyHeightM=1.65;

            bool igaze = oli.IsThinnerThan(valakiMas);
            Console.WriteLine(igaze);
           

            Pendrive pendrajvom = new Pendrive {
                Name="XX",
                Capacity=-2000,
                Price = -3000
            };
            Console.WriteLine(pendrajvom.Price); //0
            Console.ReadKey();

        }
    }
}
