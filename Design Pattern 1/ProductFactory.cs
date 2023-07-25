using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_1
{
   public  class ProductFactory
    {

        public static ICreditCard GetCreditCard(string cardType)
        {

            ICreditCard creditCard = null;

            if(cardType == "Platinum")
            {
                creditCard= new PlatinumCreditCard();
            }

            else if (cardType == "Titanium")
            {
                creditCard = new TitaniumCreditCard();
            }

            else if (cardType == "Gold")
            {

            }

            return creditCard;




        }








    }
}
