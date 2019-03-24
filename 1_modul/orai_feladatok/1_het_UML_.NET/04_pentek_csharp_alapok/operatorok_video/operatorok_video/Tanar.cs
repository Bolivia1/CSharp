using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatorok_video
{
    class Tanar
    {
        public string Nev { get; set; }
        public string Email { get; set; }
        public string FoTantargy { get; set; }

        public void KavetIszik() {
            Console.WriteLine($"{Nev} kávét iszik.");
        }
    }
}
