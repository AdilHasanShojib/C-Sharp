using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_OOP_Part_2
{
    internal class Dog : IAnimal
    {
        void IAnimal.Makesound()
        {
            Console.WriteLine("Woof!");
        }

        void IAnimal.Move()
        {
            Console.WriteLine("Running on 4 legs");
        }
    }
}
