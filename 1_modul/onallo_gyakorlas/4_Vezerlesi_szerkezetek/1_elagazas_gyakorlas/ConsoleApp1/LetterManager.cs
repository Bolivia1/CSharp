using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elagazas_gyakorlas
{        
    class LetterManager
    {
        /*5. Magánhangzó
          
        A LetterManager oszályban írj egy SkipIfVowel metódust, mely kap egy 
        karakter paramétert. Amennyiben magánhangzót kap, a következő mássalhangzót 
        adja vissza.Ha mássalhangzót kap, akkor a mássalhangzót adja vissza. Elég, 
        ha az angol ábécé karaktereivel működik.*/

        public char SkipIfVowel(char karakter)
        {
            char massalhangzo = karakter;
            char[] maganhangzok = {'a', 'e', 'i', 'o', 'u'};
            for (int i = 0; i < maganhangzok.Length; i++)
            {
                if (karakter == maganhangzok[i])
                {
                    massalhangzo = (char)(((byte)maganhangzok[i]) + 1);
                }
            }
            return massalhangzo;
        }

        /*6. Ékezetek
        Szintén a LetterManager osztályban dolgozz. Írj egy ChangeIfHungarianStrangeLetter 
        nevű metódust, mely magyar ékezetes karakter esetén annak ékezet nélküli párját 
        adja vissza.Ha a karakter nem ékezetes, akkor magát a karaktert adja vissza.*/

       /* public char ChangeIfHungarianStrangeLetter(char karakter)
        {
            char ekezetNelkuli = karakter;
            char[] nemEkezetes = {'a', 'e', 'i', 'o', 'u' };
            char[] ekezetes = {'á', 'é', 'í', 'ó', 'ú' };

            for (int i = 0; i < ekezetes.Length; i++)
            {
                if(karakter == ekezetes[i]) {
                    ekezetNelkuli = nemEkezetes[i];
                }
            }
            return ekezetNelkuli;
        }*/

       /* public char ChangeIfHungarianStrangeLetter(char karakter)
        {
            char ekezetNelkuli = karakter;
            char[] nemEkezetes = { 'a', 'e', 'i', 'o', 'u' };
            char[] ekezetes = { 'á', 'é', 'í', 'ó', 'ú' };

            if (Array.IndexOf(ekezetes, karakter) != -1)
            { int index = Array.IndexOf(ekezetes, karakter);
                ekezetNelkuli = nemEkezetes[index];
            } 
            return ekezetNelkuli;
        }*/

        public char ChangeIfHungarianStrangeLetter(char karakter)
        {
            char ekezetNelkuli = karakter;
            switch (karakter)
            {
                case 'á': ekezetNelkuli = 'a';
                    break;
                case 'é': ekezetNelkuli = 'e';
                    break;
                case 'í': ekezetNelkuli = 'i';
                    break;
                case 'ó':
                case 'ö':
                case 'ő': ekezetNelkuli = 'o';
                    break;
                case 'ú':
                case 'ü':
                case 'ű': ekezetNelkuli = 'u';
                    break;
                default: ekezetNelkuli = karakter;
                    break; 
            }
            return ekezetNelkuli;
        }
    }
}
