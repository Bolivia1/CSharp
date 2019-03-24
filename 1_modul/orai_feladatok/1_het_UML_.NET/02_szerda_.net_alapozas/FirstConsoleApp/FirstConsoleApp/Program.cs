using FirstClassLibrary;
using System;
using System.Text;

namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Your name: ");
            string name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Hello " + new Formatter().FormatName(name) + "!");
            Console.ReadLine();
        }
    }
}
