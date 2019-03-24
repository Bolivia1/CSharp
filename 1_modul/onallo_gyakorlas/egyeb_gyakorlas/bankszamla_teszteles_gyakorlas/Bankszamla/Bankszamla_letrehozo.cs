using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankszamla
{
    public class Bankszamla_letrehozo
    {
        private string tulajNeve;
        private long szamlaSzam;
        private int egyenleg;

        public Bankszamla_letrehozo(string tulajNeve, int egyenleg) {
            this.tulajNeve = tulajNeve;
            this.egyenleg = egyenleg;
            this.szamlaSzam = 999999999999;
        }

        public int EgyenlegNovelo(int berakottOsszeg) {
            egyenleg += berakottOsszeg;
            return egyenleg;
        }

        public int EgyenlegCsokkento(int kivettOsszeg)
        {
            egyenleg -= kivettOsszeg;
            validalo(egyenleg);
            return egyenleg;
        }

        private void validalo(int validalandoErtek)
        {
            if (validalandoErtek < 0) {
                throw new ArgumentOutOfRangeException("A kért összeg meghaladja a rendelkezésre álló egyenleget.");
            }
        }
    }
}
