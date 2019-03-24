using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nullable_feladat
{
    class Program
    {
        static void Main(string[] args) {
            DateTime? date = DateTime.Now;
            if(date.HasValue) {
                Console.WriteLine($"The date is {date.Value:yyyy.MM.dd}");
            }
            else {
                Console.WriteLine("No date given.");
            }

           /* 1.Satisfied Customer

            Vegyél fel egy változót, aminek a neve isSatisfiedCustomer és azt képes tárolni, 
            hogy elégedett vagy nem a vásárló vagy nem tudjuk. Próbáld ki null és nem null értékkel 
            a használatát!Írd ki a konzolra, hogy elégedett volt - e a vásárló vagy nem, vagy 
            esetleg nem árulta el.*/

            bool? isSatisfiedCustomer = null;

            if(isSatisfiedCustomer == true) {
                Console.WriteLine("A vásárló elégedett.");
            }
            else if (isSatisfiedCustomer == false) {
                Console.WriteLine("A vásárló elégedetlen.");
            }
            else {
                Console.WriteLine("Nincs elégedettségi adat.");
            }
            Console.ReadKey();
        }
    }
}
