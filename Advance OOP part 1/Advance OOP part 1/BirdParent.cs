using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_OOP_part_1
{
    internal class BirdParent
    {
        public BirdParent(string? name, string? color, string? diet)
        {
            Name = name;
            Color = color;
            Diet = diet;
        }

        public string? Name { get; set; }
        public string? Color { get; set; }

        public string? Diet { get; set; }


        public void Eat()
        {
            Console.WriteLine($"{Name} Eats {Diet}");
        }


        public virtual void Fly ()
        {
            Console.WriteLine($"{Name} can Fly");
        }










    }
}
