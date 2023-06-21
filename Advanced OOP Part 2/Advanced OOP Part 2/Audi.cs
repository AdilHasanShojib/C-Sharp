using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_OOP_Part_2
{
    internal class Audi : Car
    {
        public string Brand = "Audi";
        public string Model { set; get; }
        public Audi(int hP, string color, string model) : base(hP, color)
        {


            this.Model = model;



        }


        public new void ShowDetails()
        {

            Console.WriteLine($"Brand {Brand},HP {HP},Color {color}");
        }


        public override void Repair()
        {
            Console.WriteLine($"This {Brand} was Repared!");

        }
    }
}
