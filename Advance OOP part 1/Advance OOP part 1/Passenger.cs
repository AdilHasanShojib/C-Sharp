using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_OOP_part_1
{
    internal class Passenger
    {
        public Passenger(string name, int floorNum, int roomNum)
        {
            Name = name;
            FloorNum = floorNum;
            RoomNum = roomNum;
        }

        public string Name { get; set; }
        public int FloorNum { get; set; }
        public int RoomNum { get; set; }



    }
}
