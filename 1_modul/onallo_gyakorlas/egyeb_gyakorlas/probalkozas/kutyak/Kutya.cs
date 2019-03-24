using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kutyak
{
    public class Kutya
    {
        public string Name { get; set; }
        public int Age { get; set; }

        private int szulDatum;

        public Kutya() {
            this.szulDatum=2000;
        }

        public int szulDatumMegado() {
            return szulDatum;
        }


    }
}
