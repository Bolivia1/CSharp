using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osztaly_vs_objektum_feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            Book konyv = new Book();
            Console.WriteLine(konyv);
            Console.WriteLine(new Book());

            Book emptyBook = null;
            Console.WriteLine(emptyBook);
            //Console.WriteLine(emptyBook.Equals(null) ? "true": "false"); => NullReferencException!
            Console.WriteLine(emptyBook == null);

            Book book = new Book();
            Console.WriteLine(book);
            book = null;
            Console.WriteLine(book);

            Book anotherBook = new Book();
            Console.WriteLine(book == anotherBook);

            book = anotherBook;
            Console.WriteLine(book==anotherBook);

            Console.WriteLine(typeof(Book));
            Console.ReadKey();

           /* Book book1 = new Book();
            Book book2 = new Book();
            Book book3 = new Book();
            Book book4 = book1;
            Book book5 = book1;
            Book book6 = book3;
            Book book7 = null;
            book4 = book5;
            book5 = new Book();
            book6 = null;
            book3 = null;
            
            4 objektum jön létre, 3-hoz lehet hozzáférni
             
             */
        }
    }
}
