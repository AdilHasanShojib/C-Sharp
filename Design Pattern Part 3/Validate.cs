using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Part_3
{
   public class Validate
    {
        public bool ValidateCustomer(Customer customer)
        {


            Console.WriteLine("Customer Validate");
            Console.WriteLine("Name: {0}",customer.Name);
            Console.WriteLine("Email: {1}", customer.Email);

            return true;
        }








    }
}
