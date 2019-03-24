using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace kivetelkezeles_feladat
{
    class Patient
    {
        /*4. Rendelő

        Hozz létre egy Patient osztályt, a szükséges adatokkal:

        Name, a beteg neve
        SocialSecurityNumber, a beteg TAJ száma(string-ként tárolva, 
        hiszen 0-val is kezdődhet!)
        YearOfBirth, a beteg születési éve
        Ellenőrizd a születési évet és csak akkor fogadd el, 
        ha legalább 1900.ArgumentOutOfRangeException dobásával jelezd a 
        nem megfelelő értékeket.

        Ellenőrizd a TAJ számot is a következő algoritmussal: A TAJ szám 
        egy kilenc számjegyből álló szám.A TAJ szám első nyolc számjegyéből a 
        páratlan helyen állókat hárommal, a páros helyen állókat héttel szorozzuk, 
        és a szorzatokat összeadjuk. Az összeget tízzel elosztva a maradékot tekintjük 
        a kilencedik, azaz ellenőrző kódnak.Ha az ellenőrző kód nem egyezik, 
        akkor ne fogadd el a TAJ számot.
        ArgumentException dobásával jelezd a nem megfelelő értékeket.*/


        /*Name, a beteg neve
         SocialSecurityNumber, a beteg TAJ száma(string-ként tárolva,
         hiszen 0-val is kezdődhet!)
         YearOfBirth, a beteg születési éve
         Ellenőrizd a születési évet és csak akkor fogadd el, 
         ha legalább 1900.ArgumentOutOfRangeException dobásával jelezd a
         nem megfelelő értékeket.*/

        public string Name { get; set; }

        private int yearOfBirth;
        private string socialSecurityNumber;

        public int YearOfBirth {
            get { return yearOfBirth; }
            set {
                if(value>=1900) {
                    yearOfBirth=value;

                } else {
                    throw new ArgumentOutOfRangeException("A születési év nem lehet 1900 előtti.");
                }
            }
        }

        /* Ellenőrizd a TAJ számot is a következő algoritmussal: A TAJ szám
         egy kilenc számjegyből álló szám.A TAJ szám első nyolc számjegyéből a
         páratlan helyen állókat hárommal, a páros helyen állókat héttel szorozzuk,
         és a szorzatokat összeadjuk. Az összeget tízzel elosztva a maradékot tekintjük
         a kilencedik, azaz ellenőrző kódnak.Ha az ellenőrző kód nem egyezik,
         akkor ne fogadd el a TAJ számot.
         ArgumentException dobásával jelezd a nem megfelelő értékeket.*/

        public string SocialSecurityNumber {
            get { return socialSecurityNumber; }
            set {
                string regex = @"^\d{9}$";
                bool eredmeny = Regex.IsMatch(value, regex);
                if(eredmeny) {
                    int parosokOsszege = 0;
                    for(int i = 0; i<value.Length-1; i+=2) {                        
                        int parosElemHetszerese = 7*(int.Parse((value[i]).ToString()));
                        parosokOsszege+=parosElemHetszerese;
                    }

                    int paratlanokOsszege = 0;
                    for(int i = 1; i<value.Length-1; i+=2) {
                        int paratlanElemHaromszorosa = 3*(int.Parse((value[i]).ToString()));
                        paratlanokOsszege+=paratlanElemHaromszorosa;
                    }
                    int ellenorzoKod = (parosokOsszege+paratlanokOsszege)%10;

                    if(ellenorzoKod.ToString()==value[8].ToString()) {
                        socialSecurityNumber=value;
                    } else {
                        throw new ArgumentException("A TAJ-szám értéke nem megfelelő.");
                    }
                } else {
                    throw new ArgumentException("A TAJ-számnak számjegyekből kell állnia.");
                }
            }
        }

    }
}
