using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMethod
{
    public class MethodWithoutArgu
    {
        public int number1 { get; set; } = 6;
        public int number2 { get; set; } = 9;

        const int number3 = 10;
        const int number4 = 11;


        public int AddNumberWithoutParam()
        {


            return this.number1+this.number2;
        }

        public int AddnumberWithoutConst()
        {

            return number3 + number4;

        }




    }
      





}
