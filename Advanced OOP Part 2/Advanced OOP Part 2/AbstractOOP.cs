using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_OOP_Part_2
{
   public abstract class AbstractOOP
    {

        public string Name { get; set; }

        public virtual void GetInfo()
        {

            Console.WriteLine("This is a" + Name);
        }
       


        public abstract void SetInfo( );









    }
}
