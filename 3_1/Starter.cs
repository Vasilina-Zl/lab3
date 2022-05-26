using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_1
{
    internal class Starter
    {
        public string name;
        public int age;
        public double weight;
        public void Print_st(string name)
        {
            Console.WriteLine(name);
        }
        public void Print_int(int age)
        {
            Console.WriteLine(age);
        }
        public void Print_doub(double weight)
        {
            Console.WriteLine(weight);
        }
        public void Print_all(string name, int age, double weight)
        {
            Console.WriteLine($"Name: {name}  Age: {age} Weight {weight}");
        }

    }
   

  class Color : Starter
    {
        public void Print_str(string Name)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            base.Print_st(name);
            Console.BackgroundColor = ConsoleColor.Black;
        }
        public void Print_intt(int age)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            base.Print_int(age);
            Console.BackgroundColor = ConsoleColor.Black;
        }
        public void Print_doubl(double weight)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            base.Print_doub(weight);
            Console.BackgroundColor = ConsoleColor.Black;
        }
        public void Print_All(string name, int age, double weight)
        {
            Console.WriteLine($"Name: {name}  Age: {age} Weight {weight}");
        }

    }
}