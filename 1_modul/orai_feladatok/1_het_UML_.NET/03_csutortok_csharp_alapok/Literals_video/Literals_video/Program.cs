using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Literals_video
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = null;
            bool b = true;
            IntegerLiterals();

            var result = 13 / 12d;  //int-be teszi bele eredetileg, mivel a két operandus integer
            Console.WriteLine("Result: " + result);



            var floatingPointNumber = 12.3e5; //12.3*10**5
            Console.WriteLine("floatingPointNumber: " + floatingPointNumber);

            char ch = '\n'; //escape szekvencia, new line
            //char ch = '\x27';  hexadecimális  - aposztróf
            ch = '\u0027';  //ezt használjuk => unicode-ra utal
            Console.WriteLine(ch);

            //string emailBody = "Szia! \nMegkaptuk a jelentkezésedet. \nÜdv, \nYellowroad csapata"; //sortörések beszúrva

            //verbatim string:
            string emailBody = 
                @"Szia! 
                Megkaptuk a jelentkezésedet.
                Üdv,
                Yellowroad csapata";
            Console.WriteLine(emailBody);
        }

        private static void IntegerLiterals() {
            var integerLiteral = 17;
            Console.WriteLine("Integer: " + integerLiteral);

            var integerLiteralHexa = 0x11;
            Console.WriteLine("Given in hexa: " + integerLiteralHexa);

            var integerLiteralBinary = 0b0001_0001; //4 bitenként elválasztó aláhúzásjel
            Console.WriteLine("Given in binary: " + integerLiteralBinary);

            var integerNumber = 123456789123456789;
            var integerNumber2 = 1234567891234567891;

            var integerNumber3 = 123456789uL;

        }

    }
}
