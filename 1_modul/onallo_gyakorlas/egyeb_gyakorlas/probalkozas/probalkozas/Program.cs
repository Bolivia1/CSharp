using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Text.RegularExpressions;
using kutyak;

namespace probalkozas
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime jelenlegiIdo = DateTime.Now;
            Console.WriteLine(jelenlegiIdo);


            Nullable<DateTime> regiIdo = null;
            string proba = null;
            Console.WriteLine(proba?.ToUpper());
            Console.WriteLine(proba);
            
            Console.WriteLine(regiIdo);
            Console.WriteLine(regiIdo.HasValue);
            //Console.WriteLine(regiIdo.Value);
            Console.WriteLine(regiIdo.ToString());

            ArrayList kutyak = new ArrayList();

            Kutya kutya1 = new Kutya();
            Kutya kutya2 = new Kutya();
            Kutya kutya3 = null;

            kutya1.Name = "Bodri";
            kutya1.Age = 12;
            Console.WriteLine(kutya2.szulDatumMegado());

            kutya2.Name = "Kutyus";
            kutya2.Age = 10;

            kutyak.Add(kutya1);
            kutyak.Add(kutya2);

            Console.WriteLine(((Kutya)kutyak[0]).Name);

            StringBuilder sb = new StringBuilder("Hello");
            sb.Append(" ");
            sb.Append("world!");
            string koszontes = sb.ToString();
            Console.WriteLine(koszontes);

            string ujKoszones = "Hello World!";
            Console.WriteLine(ujKoszones);
            //bool egyeznek = koszontes.Equals(ujKoszones);
            bool egyeznek = String.Compare(koszontes, ujKoszones, true)==0;
            string uzenet = egyeznek ? "A két string azonos" : "A két string nem azonos.";
            Console.WriteLine(uzenet);

            string tajszam = "012345678";
            string regex = @"^\d{9}$";
            bool helyes = Regex.IsMatch(tajszam, regex);
            Console.WriteLine(helyes);

            char karakter = 'e';
            byte konvertaltKarakter = (byte)karakter;
            string stringgeKonvertalt = karakter.ToString();
            string masikStringgeKonvertalt = konvertaltKarakter.ToString();
            Console.WriteLine(karakter);
            Console.WriteLine(konvertaltKarakter);
            Console.WriteLine(stringgeKonvertalt);
            Console.WriteLine(masikStringgeKonvertalt);


            /* string[] stringek = { "alma", "karalábé", "hús" };
             int aBetukSzama = 0;
             char keresettKarakter = 'a';
             StringBuilder sbx = new StringBuilder();
             for(var i = 0; i<stringek.Length; i++) {
                 sbx.Append(stringek[i]);
                 sbx.Append(" ");
             }
             string strOsszefuzes = sbx.ToString();            

             for(int i = 0; i<strOsszefuzes.Length; i++) {
                 if(strOsszefuzes[i]==keresettKarakter) {
                     aBetukSzama++;
                 }                 
             }

             string betukUzenet = aBetukSzama>0?"A megadott szövegben "+aBetukSzama+" darab "+keresettKarakter+" betű volt.": "A megadott szövegben nem volt egyetlen egy "+keresettKarakter+" sem";
             Console.WriteLine(betukUzenet);*/


            long longValue = Int64.MaxValue;
            int intValue = (int)longValue;
            Console.WriteLine("(int) {0} = {1}", longValue, intValue);

            int number = int.MaxValue;
            Console.WriteLine(checked(++number));

            Console.ReadKey();

        }
    }
}
