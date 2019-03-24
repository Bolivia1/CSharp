using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halado_unit_teszteles_feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            Gentleman billy = new Gentleman();
            Console.WriteLine(billy.SayHello(null));
            Console.ReadKey();
        }
    }
}
