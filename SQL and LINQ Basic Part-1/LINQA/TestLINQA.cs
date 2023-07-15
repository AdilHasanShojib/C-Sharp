using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQA
{
    internal class TestLINQA
    {


        public static void TestOddNum()
        {

            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            IEnumerable<int>  oddNum= from number in num where number%2 != 0 select number;

            //Console.WriteLine(oddNum);

            //foreach (var item  in oddNum) Console.WriteLine("Odd Num "+item);

            var oddNum1 = num.Where(x => x%2 != 0);

            foreach (var item in oddNum1) Console.WriteLine("Odd Num " + item);


        }



        public static  void OrdersortBy()
        {
            int[] number = {31, 92, 43, 74, 45, 56, 17, 28, 39 };

            IEnumerable<int> sort=  from i in number orderby i descending  select i;

            var sortedInt = number.OrderBy(x => x).ToList();
            
            foreach (var item in sortedInt) Console.WriteLine(" " + item);

        }




    }
}
