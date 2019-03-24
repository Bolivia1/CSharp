using System;
using Yellowroad;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bevezetes_a_metodusok_hasznalataba_feladat
{
    class Program
    {
        static void Main(string[] args) {

            BodyMass oli = new BodyMass();
            oli.BodyMassKg=58d;
            oli.BodyHeightM=1.74;
            Console.WriteLine(oli.GetBodyMassIndex());

            BodyMass valakiMas = new BodyMass();
            valakiMas.BodyMassKg=80d;
            valakiMas.BodyHeightM=1.65;

            bool igaze = oli.IsThinnerThan(valakiMas);
            Console.WriteLine(igaze);

            Pendrive ujPendrive = new Pendrive {
                Name="HP",
                Capacity=10,
                Price=6000
            };

            Console.WriteLine(ujPendrive.ToString());
            Console.WriteLine(ujPendrive.Price);
            ujPendrive.IncreasePrice(30);
            Console.WriteLine(ujPendrive.Price);

            Pendrive megUjabbPendrive = new Pendrive {
                Name="XX",
                Capacity=12,
                Price=10000
            };
            int dragabbjobb = ujPendrive.ComparePricePerCapacity(megUjabbPendrive);
            Console.WriteLine(dragabbjobb);

            bool olcsobb = ujPendrive.IsCheaperThan(megUjabbPendrive);
            Console.WriteLine(olcsobb);

            Client ugyfel = new Client();
            ugyfel.Move("Budapest");
            Console.WriteLine(ugyfel.Address);
            Console.ReadKey();

        }
    }
}
