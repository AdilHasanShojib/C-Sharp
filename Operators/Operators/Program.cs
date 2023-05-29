using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int num1 = 10;
            int num2 = 100;

            int add = num2 + num1;
            int sub=num2 - num1;
            int mult=num2*num1;
            int div=num2/num2;
            int mod=num2%num1;

            Console.WriteLine($"ADD:- {add} \n SUB:- {sub} \n MULT:- {mult} \n DIV:- {div} \n MOD:- {mod}");
            Console.ReadKey();



        }
    }
}
