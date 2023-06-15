using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAcessaaModify
{
 public class Bicycle:CycleSell       
    {

      public int Wheels { get; set; }
      
        public void StartBycycle()
        {
            Console.WriteLine("Cycle Started");
        }

        public void AttachWheels()
        {
            Console.WriteLine($"You have attached {Wheels} wheels");


        }


        public void GenerateInvoice()
        {
            var Cycle = new Bicycle();
            Cycle.SetPrice(1000);
            Cycle.quantity = 5;
            Cycle.Invoice();



        }


    }
}
