using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModify
{
    internal class Array
    {

        public static void AssignArray()
        {

            int[] array = { 1, 2, 3, 4, 5, 6, 7 };

            Console.WriteLine("array at index 2 -->" + array[1]);
            Console.WriteLine("array length is "+array.Length);


        }

         public static void ArrayLoop()
        {

            int[] num =new int[10];

            for(int i=0;i<num.Length; i++)
            {
                num[i] = i;
            }

            for (int j = 0; j < num.Length; j++)
            {
                Console.WriteLine($"Array elment {j} = {num[j]}");
            }
            int Count = 0;
            foreach (int k in num)
            {
                Console.WriteLine($"Element {k} = {Count++}");
            }

        }


        public static void MultiArray() {
            int[,] array = { {1,2,3},
                             {4,5,6},
                             {5,6,7}

                             };

            Console.WriteLine("The value is " + array[2,2]);
        
        
        }


    }
}
