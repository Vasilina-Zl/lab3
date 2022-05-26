using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal("Frog");
            animal.Sound();

            Cat cat = new Cat("cat", "Black");
            cat.Sound();

            Dog dog = new Dog("dog", "Big");
            dog.Sound();
        }
    }
}
