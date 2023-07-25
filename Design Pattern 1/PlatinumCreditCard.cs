using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_1
{
    public class PlatinumCreditCard : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 500;
        }

        public string GetCardType()
        {
            return "Platinum Card";
        }

        public int GetCreditLimit()
        {
            return 15000;
        }
    }
}
