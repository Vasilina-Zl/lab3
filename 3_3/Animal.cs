using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_3
{
	internal class Animal
	{
        
            public string Name { get; set; }
            public Animal(string name)
            {
                Name = name;
            }

            public virtual void Sound()
            {
                Console.WriteLine($"{Name} says ...");

            }
        }
        class Cat : Animal
        {
            public string Color { get; set; }
            public Cat(string name, string color)
            : base(name)
            {
                Color = color;
            }
            public override void Sound()
            {
              
                Console.WriteLine($"{Color} {Name} says Nyaw");
            }
        }
        class Dog : Animal
        {
            public string Size { get; set; }
            public Dog(string name, string size)
            : base(name)
            {
                Size = size;
            }
            public override void Sound()
            {
            
                Console.WriteLine($"{Size} {Name} says Bark");
            }

        }
    }
