using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_OOP_Part_2
{
    internal class Cat : IAnimal
    {
        void IAnimal.Makesound()
        {
            Console.WriteLine("Meow!");
        }

        void IAnimal.Move()
        {
            Console.WriteLine("Jumping and Climbing!");
        }
    }
}
