using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2
{
	internal class Person_B
	{
        public string Name { get; set; }
        public Person_B(string name)
        {
            Name = name;
        }
        public virtual void Print()
        {
            Console.WriteLine(Name);
        }
    }
    class Adult : Person_B
    {
        public string Company { get; set; }
        public Adult(string name, string company)
            : base(name)
        {
            Company = company;
        }

        public override void Print()
        {
            Console.WriteLine($"{Name} працює в {Company}");
        }
    }
    class Children : Person_B
    {
        public string School { get; set; }
        public Children(string name, string school)
            : base(name)
        {
            School = school;
        }

        public override void Print()
        {
            Console.WriteLine($"{Name} пнавчається в {School}");
        }
    }
}
