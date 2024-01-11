using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Part_3
{
  public class CustomerDataAccess
    {

        public bool SaveCustomer(Customer customer)
        {
            Console.WriteLine("\n customer saved into dataBase");

            return true;
        }



    }
}
