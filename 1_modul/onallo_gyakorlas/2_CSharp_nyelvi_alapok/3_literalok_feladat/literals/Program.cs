using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace literals
{
    class Program
    {
        static void Main(string[] args)
        {

            /*1.Osztás

            Vedd a 3 és a 4 hányadosát, és tárold el a double quotient változóban.Írd ki, 
            mi lesz az eredmény? Miért van ez így? Hogyan lehet ezt pontosítani kizárólag 
            literálok használatával?*/

            double quotient = 3d / 4;
            Console.WriteLine(quotient);
            //Console.ReadLine();


            /*2.Szó szerint

            Írd át a következőket verbatim stringre:

            string imageFile = "C:\\yellowroad\\images\\yellowroadlogo.png";
            string emailBody = "Szia!\nMegkaptuk a jelentkezésedet.\nÜdv,\nYellowroad csapata";*/
            string imageFile = @"C:\\yellowroad\\images\\yellowroadlogo.png";  //verbatim string
            Console.WriteLine(imageFile);

            //string emailBody = @"Szia!\nMegkaptuk a jelentkezésedet.\nÜdv,\nYellowroad csapata";
            string emailBody = @"Szia!
            Megkaptuk a jelentkezésedet.
            Üdv,
            Yellowroad csapata";


            Console.WriteLine(emailBody);
            Console.ReadLine();
        }
    }
}
