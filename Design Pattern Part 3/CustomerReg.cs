using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Part_3
{
    public class CustomerReg
    {

        public bool RegCustomer(Customer customer)
        {
            Validate valid = new Validate();
            bool Isvalid = valid.ValidateCustomer(customer);
            CustomerDataAccess access = new CustomerDataAccess();
            bool Issaved = access.SaveCustomer(customer);

            Email email = new Email();
            email.SendRegEmail(customer);
            return true;

        }
     


    }
}
