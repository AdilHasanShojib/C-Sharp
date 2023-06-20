using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_OOP_Part_2
{
    internal class Car
    {
        public Car(int hP, string color)
        {
            HP = hP;
            this.color = color;
        }

        MS ms = new MS();

        public void SetDetails(int ls,string owner)
        {
            ms.LicenceNum = ls;
            ms.OwnerShip = owner;
        }

        public void getDetails()
        {
            Console.WriteLine($"The CAR HAS THE LICENCE NUM {ms.LicenceNum},owned by {ms.OwnerShip}");
        }

        public int HP { set; get; } 
        public string color { set; get; }

        public void ShowDetails()
        {
            Console.WriteLine("HP {0} , COLOR {1}",HP,color);
        }

        public virtual void Repair()
        {
            Console.WriteLine("Car Has Reapair");
        }





    }
}
