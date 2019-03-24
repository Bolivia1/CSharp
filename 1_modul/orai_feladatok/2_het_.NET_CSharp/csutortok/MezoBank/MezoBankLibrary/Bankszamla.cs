using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MezoBankLibrary
{
    public class Bankszamla
    {
        private string tulajneve;        
        private int szamlaszam;
        private int egyenleg;

        public Bankszamla(string tulajneve)
        {
            this.tulajneve = tulajneve;
            this.szamlaszam = -99;
            this.egyenleg = 0;
        }

        public int EgyenlegetNovel(int befizetettOsszeg)
        {                        
            NemLehetNegativValidalo(befizetettOsszeg);
            NemLehetNegativValidalo(egyenleg);
            this.egyenleg += befizetettOsszeg;
            return this.egyenleg;
        }

        public int EgyenlegetCsokkent(int kifizetettOsszeg)
        {            
            this.egyenleg -= kifizetettOsszeg;
            NemLehetNegativValidalo(egyenleg);
            return this.egyenleg;
        }

        private void NemLehetNegativValidalo(int vizsgalando)
        {
            if (vizsgalando < 0)
            {
                throw new ArgumentOutOfRangeException("Az egyenleg nem lehet negatív.");
            }
        }

    }
}
