using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_1
{
    internal class TitaniumCreditCard : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 1000;
        }

        public string GetCardType()
        {
            return "Titanium Card";
        }

        public int GetCreditLimit()
        {
            return 150000;
        }
    }
}
