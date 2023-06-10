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



        public void setname(string name)
        {
            this.name = name;

        }

        public string getname(string name)
        {
            return this.name;

        }

        //public string setName { get; set; } = "Taxi-600";

        //Default Constructor
        public Car() {

            Console.WriteLine("Car Has Created");
        
        }


        // fully Constructor


        public Car(Color color, string name, string brand,DateTime year)
        {
            this.color=color;
            this.name=name;
            this.brand=brand;
            this.year=year;


        }
        // Partial Constructor

        public Car(Color color,string name,string brand)
        {
            this.color = color; 
            this.name=name;
            this.brand=brand;
        }





        public void Start()
        {
            Console.WriteLine($"{this.name} Has Started");
        }


        public void Speed() {


            Console.WriteLine($"{this.name} speed is 180 km/h");

        }




        public void CarDetails()
        {


            Console.WriteLine($"{this.name} is a car. which color is {this.color}. And its brand is {this.brand}. Its Realease {this.year} years ago");

        }







    }
}
