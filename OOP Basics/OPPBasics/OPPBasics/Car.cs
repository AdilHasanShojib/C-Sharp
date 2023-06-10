using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPBasics
{      
    public enum Color
    {

        Red,
        Green,
        Blue,
        Yellow     


    }


    internal class Car
    {

        public Color color;
        public string name;
        public string brand;
        public DateTime year;

        public static int price;


        public void Start()
        {
            Console.WriteLine("Car Has Started");
        }


        public void Speed() {


            Console.WriteLine("Car speed is 180 KM/H");

        }











    }
}
