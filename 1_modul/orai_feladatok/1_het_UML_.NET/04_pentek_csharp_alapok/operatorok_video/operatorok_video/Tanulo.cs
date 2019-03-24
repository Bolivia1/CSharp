using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatorok_video
{
    class Tanulo
    {
        public string Nev {get; set;}
        public DateTime szulDatum {get; set;}

        public void Jatszik() {
            Console.WriteLine($"{Nev} játszik...");
        }
    }
}
