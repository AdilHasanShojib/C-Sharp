using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAcessaaModify
{
public class CycleSell
    {

        private int price;

        protected int quantity { set; get; }

        protected void SetPrice(int taka)
        {
            price = taka;

        }
        


        public void Invoice()
        {
            Console.WriteLine($"Your total is {price * quantity}");


        }



    }



}
