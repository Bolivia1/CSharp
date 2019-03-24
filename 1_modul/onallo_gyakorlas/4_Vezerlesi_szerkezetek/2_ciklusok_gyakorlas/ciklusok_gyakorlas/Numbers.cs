using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ciklusok_gyakorlas
{
    public class Numbers
    {
        /*A feladatot a Numbers osztályban valósítsd meg! A public string 
        GetNumbersBetween(int min, int max) metódusban add vissza a pozitív 
        egész számokat a két paraméterként megadott érték között egy stringben 
        szóközzel elválasztva. (A min, max ne legyen benne.)*/

        public string GetNumbersBetween(int min, int max) {

            int kiirandoSzam = min+1;
            string stringSzamokStringje = String.Empty;

            while(kiirandoSzam<max) {

                if(kiirandoSzam>0) {
                    stringSzamokStringje+=kiirandoSzam.ToString()+' ';
                }
                kiirandoSzam++;
            }
            return stringSzamokStringje;
        }

        // Alexa verziója
         
         public string ArrayListToString(ArrayList szamokTombje) {

           string result = string.Empty;
           StringBuilder stringList = new StringBuilder();

           foreach (int szam in szamokTombje) {
               stringList.Append(szam);
               stringList.Append(" ");
           }
           result = stringList.ToString();
           return result;
       }

       public string GetNumbersBetween2(int min, int max) {

           string result="";
           ArrayList szamok = new ArrayList();

           for (int i=min+1; i<max; i++) {
                if (i>0) {
                    szamok.Add(i);
               }
           }
           result=ArrayListToString(szamok);
           return result;
       }
             
            

        /*A public string GetNumbersBetweenAnyDirection(int min, int max) metódusban 
         add vissza a pozitív egész számokat a két paraméterként megadott érték között, 
         ha a min értéke nagyobb, mint a max értéke, akkor visszafelé. (A min, max ne legyen benne.)*/

        public string GetNumbersBetweenAnyDirection(int min, int max) {
            string stringSzamokTombje = String.Empty;

            if(min<max) {
                int kiirandoSzam = min+1;
                
                while(kiirandoSzam<max) {
                    if(kiirandoSzam>0) {
                        stringSzamokTombje+=kiirandoSzam.ToString()+' ';
                    }
                    kiirandoSzam++;
                }

            } else if(min>max) {
                int kiirandoSzam = min-1;
                while(kiirandoSzam>max) {
                    if(kiirandoSzam>0) {
                        stringSzamokTombje+=kiirandoSzam.ToString()+' ';
                    }
                    kiirandoSzam--;
                }

            } else {
                
                if(min>0) {
                    stringSzamokTombje+=min;
                }
            }
            return stringSzamokTombje;
        }

        /*A public string GetOddNumbers(int max) metódusban add vissza a páratlan pozitív 
          egész számokat(eggyel indítva) egészen a paraméterként megadott számig
          (az is legyen benne, ha páratlan).*/

        public string GetOddNumbers(int max) {
            int index = 1;
            string stringParatlanokStringje = String.Empty;

            while(index<=max) {
                if(index%2==1) {
                    stringParatlanokStringje+=index.ToString()+' ';                    
                }
                index++;
            }
            return stringParatlanokStringje;
        }

    }
}

