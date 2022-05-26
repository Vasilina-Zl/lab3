using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Starter printer = new Starter();
            printer.name = "Lina";
            printer.age = 12;
            printer.weight = 1.87;
            printer.Print_all(printer.name, printer.age, printer.weight);

            Color color = new Color();
            color.name = "Ann";
            color.age = 13;
            color.weight = 1.52;
            Console.Write("Name: ");
            color.Print_str(color.name);
            Console.Write("Age: ");
            color.Print_intt(color.age);
            Console.Write("Wieght: ");
            color.Print_doubl(color.weight);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ReadKey();

        }
    }
}