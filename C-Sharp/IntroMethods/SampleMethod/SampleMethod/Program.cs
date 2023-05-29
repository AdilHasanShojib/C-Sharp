using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Adding two Number:");
            //var add = AddNumber(2, 5);
            //Console.WriteLine("After adding we got : "+add);
            //Console.ReadKey();

            var sum = new MethodWithoutArgu();
            var result1=sum.AddNumberWithoutParam();
            Console.WriteLine(result1 );
            var result2=sum.AddnumberWithoutConst();
            Console.WriteLine(result2 );
            Console.ReadLine();
           



        }


        static int AddNumber(int a, int b) {  return a + b; }


    }
}
