using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_OOP_part_1
{
    internal class WaterCraft
    {

        public WaterCraft(string? name, int length, int capacity)
        {
            Name = name;
            Length = length;
            Capacity = capacity;
        }

        public string? Name { get; set; }
        public int Length { get; set; }

        public int Capacity { get; set; }


        public void StartEngine()
        {
            Console.WriteLine($"{Name} has started");
        }

        public void StopEngine()
        {

            Console.WriteLine($"{Name} has stopped");

        }



















    }
}
