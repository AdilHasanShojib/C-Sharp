using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_1
{
   public static class ClientCodeFactory
    {


        public static void WithusingFactoryCreditCard()
        {
            ICreditCard platinum = ProductFactory.GetCreditCard("Platinum");

            if(platinum != null)
            {

                Console.WriteLine("CardType:{0}",platinum.GetCardType());
                Console.WriteLine("Card Limit:{0}",platinum.GetCreditLimit());
                Console.WriteLine("Annual Charge:{0}",platinum.GetAnnualCharge());

            }


            else
            {
                Console.WriteLine("Invalid Credit Card");
            }



        }












    }
}
