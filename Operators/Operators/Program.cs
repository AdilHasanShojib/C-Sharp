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
            //int num1 = 10;
            //int num2 = 100;

            //int add = num2 + num1;
            //int sub=num2 - num1;
            //int mult=num2*num1;
            //int div=num2/num2;
            //int mod=num2%num1;

            //Console.WriteLine($"ADD:- {add} \n SUB:- {sub} \n MULT:- {mult} \n DIV:- {div} \n MOD:- {mod} \n");


            //var num3 = 4;
            //var num4 = 49;
            //var num5 = 40;
            //var num6 = 455;
            //var num7 = 41;

            //var checkPrecedence = num3 + num6 * (num7 - num3) + num5 + num4 / num3;
            //Console.WriteLine("Result:- " + checkPrecedence);
            ////BODMAS (BRACKET,ORDER,DIVISION,MULTIPICATION,ADD,SUB)
            //Console.ReadKey();


            //int x = 10;
            //int y = 20;
            //int a = x++;
            //int b = --y;
            //Console.WriteLine($"A:- {x} \n B:- {y}");
            //Console.ReadKey();

            //int a = 20;
            //int b = 40;
            //Console.WriteLine(a>b);
            //Console.WriteLine(b<a);
            //Console.WriteLine(a==b);
            //Console.WriteLine(b!=a);
            //Console.WriteLine(a<=b);
            //Console.WriteLine(b>=a);



            //int a = 10; //00001010
            //int b = 15; //00001111
            //int bitwiseResult = a & b;
            //Console.WriteLine(bitwiseResult);
            //Console.ReadKey();

            //string firstName = "shojib";
            //string lastName = "Talukder";
            //Console.WriteLine(firstName==lastName || firstName!=lastName);
            //Console.WriteLine(firstName == lastName && firstName != lastName);
            //Console.ReadKey();

            //try
            //{
            //    int firstNum=int.Parse(Console.ReadLine());
            //    int secondNum=int.Parse(Console.ReadLine());

            //    int result=firstNum/secondNum;  
            //    Console.WriteLine("Result:- "+result);


            //}
            //catch (DivideByZeroException ex) { 
            
            
            //   Console.WriteLine($"Error:- Division by Zero is not allowed {ex.Message}");
            
            
            
            
            //}  
            //finally { Console.WriteLine("Fianly Done"); }

            //Console.ReadKey();


            //int num = 60;

            //if(num >= 0)
            //{
            //    Console.WriteLine("Positive Number:-");

            //    if(num%2== 0)
            //    {
            //        Console.WriteLine("Even Number "+num);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Odd Number"+num);
            //    }
            //}

            //else { Console.WriteLine("Negative Number" + num);
            //}
            //Console.ReadKey();


            //if (num == 0)
            //{
            //    Console.WriteLine("Number is 0");
            //}
            //else if (num == 10)
            //{
            //    Console.WriteLine("Number is 10");
            //}

            //else if (num == 20)
            //{
            //    Console.WriteLine("Number is 20");
            //}

            //else
            //{
            //    Console.WriteLine("Number is 60");

            //}

            //switch (num)
            //{
            //    case 0: Console.WriteLine("Num 0");
            //        break;
            //    case 1: Console.WriteLine("Num 10");
            //        break;
            //    case 2: Console.WriteLine("Num 20");
            //        break;
                   
            //    default: Console.WriteLine("Num 60");
            //        break;
            //}

            //Console.ReadKey();

            performance perform= new performance();
            perform.Checkperformance();






        }
    }
}
