using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_OOP_Part_2
{
    internal class Cube : AbstractOOP
    {    public int length { set; get; }

        public Cube(int length)
        {
            this.length = length;
        }

        public override void SetInfo()
        {

            Console.WriteLine("The cube has length "+length);


        }

    }
}
