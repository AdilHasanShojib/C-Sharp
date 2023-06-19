using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_OOP_part_1
{
    internal class Titanic : WaterCraft, ISinkable
    {
       public List<ISinkable> SinkAllabe { get; set; }

        public Titanic(string name,int length,int capacity) : base(name, length, capacity)
        {
            SinkDuration = capacity-10;
            SinkAllabe = new List<ISinkable>();


        }

        public int SinkDuration { get ; set ; }

        public void sink()
        {
            Console.WriteLine($"The watercraft {Name} , which is {Length} unit bits");
            Console.WriteLine($"The watercraft {Name} will sink in {SinkDuration} min");
            Console.WriteLine("*******************************************");


            foreach (ISinkable item in SinkAllabe)
            {
                item.sink();
            }




        }
    }
}
