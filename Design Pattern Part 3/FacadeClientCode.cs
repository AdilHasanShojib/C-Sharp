using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Part_3
{
    public static class FacadeClientCode
    {


        public static void WithoutFacade()
        {
            Customer customer = new Customer
            {

                Name = "SANI",
                Email = "Sani30@gmail.com"
            };










            CustomerReg customerReg = new CustomerReg();
            customerReg.RegCustomer(customer);



        }

    }
}
