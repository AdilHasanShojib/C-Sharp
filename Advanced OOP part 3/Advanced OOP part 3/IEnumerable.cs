using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_OOP_part_3
{
    internal class IEnumerable
    {

        public static void CollectionSum(IEnumerable<int> collection)
        {

            int sum = 0;
            foreach (int item in collection)
            {
                sum += item;
            }

            Console.WriteLine("Sum is {0}",sum);


        }
    }
}
