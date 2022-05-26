using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person_B tom = new Adult("Tom", "Microsoft");
            tom.Print();

            Person_B lisa = new Children("Lisa", "School #3");
            lisa.Print();
        }
    }
}