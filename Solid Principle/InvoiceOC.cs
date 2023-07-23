using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle
{

    public enum Invoicetype
    {

        FinalInvoice, 
        ProposedInvoice
    }
    public class InvoiceOC
    {
        public static double GetInvoiceDiscount(double ammount, Invoicetype invoicetype)
        {

            double finalAmount = 0;
            if (invoicetype == Invoicetype.FinalInvoice)
            {
                finalAmount = ammount - 100;
            }


            else if (invoicetype == Invoicetype.ProposedInvoice)
            {
                finalAmount = ammount - 50;
            }

            return finalAmount;
        }










    }
}
