using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ciklusok_gyakorlas
{
    class Program
    {
        public static void Main(string[] args) {
            Numbers szamok = new Numbers();

            Console.WriteLine(szamok.GetNumbersBetween(-15, 30));

            Numbers szamTartomany = new Numbers();
            Console.WriteLine(szamTartomany.GetNumbersBetweenAnyDirection(-20, 40));

            Numbers paratlanok = new Numbers();
            Console.WriteLine(paratlanok.GetOddNumbers(28));

            Console.WriteLine(SzokoevSzamito());

            Console.WriteLine(HaromszogGyarto(5));

            Console.WriteLine(CukorkaOszto(9));
            MuveletEllenorzo();

            Console.ReadKey();
        }

        /*2. Szökőévek
         Írj egy metódust, mely visszaadja az 1899 és 2017 közötti 
         szökőéveket egy stringben;-vel elválasztva.*/

        public static string SzokoevSzamito() {

            int ev = 1899;
            int zaroEv = 2017;
            string szokoEvek = String.Empty;

            while(ev<=zaroEv) {
                if((ev%4==0 && ev%100!=0) || ev%400 == 0) {
                    if(zaroEv-ev >4) {
                        szokoEvek+=ev.ToString()+", ";
                    } else {
                        szokoEvek+=ev.ToString();
                    }
                }
                ev++;
            }
            return szokoEvek;
        }

        public static string HaromszogGyarto(int szam) {
            string haromszogString = String.Empty;

            for(int i = 1; i<=szam; i++) {
                for(int j = 1; j<=i; j++) {
                    haromszogString+=i.ToString();
                }
                haromszogString+='\n';
            }

            return haromszogString;
        }

        /*4. Cukorka nem testvériesen
        Írj egy metódust, mely megkapja paraméterként, hogy hány cukorkát kell 
        szétosztani egyenlőtlenül: az első gyerek 1 cukorkát kap a második kettőt, 
        és így tovább minden rákövetkező eggyel többet kap, mint az előző, ha nem 
        marad elég cukor az utolsó gyereknek akkor is odaadjuk a maradékot.A metódus 
        visszaadja, hogy hány gyerek kap ezzel a módszerrel cukorkát.*/

        public static int CukorkaOszto(int cukorkakSzama) {
            int gyerekekSzama = 0;

            //9 cukorka
            //i=1,  gyerekekSzama = 1  kiadottCukorka = 1
            //i=2,  gyerekekSzama = 2  kiadottCukorka = 1+2 (3)
            //i=3,  gyerekekSzama = 3  kiadottCukorka = 1+2+3 (6)
            //i=4   gyerekekSzama = 4  kiadottCukorka = 10 helyett 1+2+3+3 (9) vége 

            for(int i = 1; cukorkakSzama>=0; i++) {
                cukorkakSzama-=i; //cukorkakSzama=8; cukorkakSzama=6; cukorkakSzama=3; *cukorkakSzama=-1
                gyerekekSzama=i;  //gyerekekSzama=1; gyerekekSzama=2; gyerekekSzama=3; *gyerekekSzama=4
            }
            return gyerekekSzama;
        }

        /*5. Számolás gyakorló
        Az előző leckében elkészített 4 matematikai alapműveletet elvégző metódus 
        használatával írj egy kis konzolos programot, ami kérdez egy véletlen műveletet 
        véletlen 1 és 100 közötti számokkal és addig kérdezi ugyanazt, amíg meg nem kapja 
        a helyes eredményt.*/

        public static void MuveletEllenorzo() {

            Random rnd1 = new Random();
            Random rnd2 = new Random();
            string[] muveletiJelek = { "+", "-", "*", "/" };
          
            int num1 = rnd1.Next(1, 100);            
            int num2 = rnd1.Next(1, 100);
            int num3 = rnd2.Next(1, 4);     

            string muveletiJel = muveletiJelek[num3];

            MathCalculator muvelet = new MathCalculator();
            double eredmeny=muvelet.Calculate(num1, num2, muveletiJel);

            Console.WriteLine(num1.ToString()+muveletiJel+num2.ToString()+"=");

            int tippekSzama = 0;
            double tipp = 0;

            do {
                Console.Write("Add meg az eredményt! ");
                tipp=double.Parse(Console.ReadLine());
                tippekSzama++;
            }
            while(eredmeny!=tipp);

            if(eredmeny==tipp) {
                Console.WriteLine($"Az eredmény helyes! Tippek száma: {tippekSzama}");
            }
        }
    }
}
