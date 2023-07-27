using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_2
{
    public class student
    {


        public string Name { set; get; }
        public string Department { set; get; }
        public string University { set; get; }

        public student GetClone()        // shalow copy (USING IN non static & value type only)
        {
            return  (student)this.MemberwiseClone();
        }


    }
}
