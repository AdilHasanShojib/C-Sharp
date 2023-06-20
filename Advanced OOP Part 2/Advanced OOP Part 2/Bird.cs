using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_OOP_Part_2
{
    internal class Bird : IAnimal
    {
        void IAnimal.Makesound()
        {
            Console.WriteLine("Chirp!");
        }

        void IAnimal.Move()
        {
            Console.WriteLine("Flying in the sky!");
        }
    }
}
