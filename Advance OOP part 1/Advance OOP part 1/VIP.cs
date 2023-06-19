using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_OOP_part_1
{
    internal class VIP : Passenger, ISinkable
    {

        public VIP(string name,int floorNum,int roomNum) : base(name, floorNum, roomNum)
        {
            SinkDuration = 10;

        }

        public int SinkDuration { get; set ; }

        void ISinkable.sink()
        {
            Console.WriteLine($"The watercraft {Name}");
            Console.WriteLine($"The watercraft {Name} will sink in {SinkDuration} min");
            Console.WriteLine("-----------------------------------------------");

        }
    }
}
