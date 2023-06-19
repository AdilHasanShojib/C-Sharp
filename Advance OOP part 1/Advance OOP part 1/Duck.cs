using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_OOP_part_1
{
    internal class Duck:BirdParent
    {
        public bool IsFly { set; get; }=true;



        public Duck(string name,string color,string diet): base(name, color, diet)
        {




        }


        public override void Fly()
        {
            Console.WriteLine($"{Name} Can't Fly");
            base.Fly();
        }


    }
}
