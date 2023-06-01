using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    public class performance
    {

        public void Checkperformance() {

            const int Iteration = 1000000;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < Iteration; i++)
            {
                TestSwitch(5);
            }
           stopwatch.Stop();
            Console.WriteLine($"Switch Statement Time :- {stopwatch.ElapsedMilliseconds} ms");
            stopwatch.Restart();

            //Test If Else

            stopwatch.Start();
            for (int i = 0; i < Iteration; i++)
            {
                TestIfElse(5);
            }
            stopwatch.Stop();
            Console.WriteLine($"IfElse Statement Time :- {stopwatch.ElapsedMilliseconds} ms");
            stopwatch.Restart();

            Console.ReadLine();





        }

        public void TestSwitch(int num) {

            switch (num)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
               

                default:
                    break;
            }
           




        }

        public void TestIfElse(int num)
        {
            if (num == 0)
            {

            }

            else if (num == 1)
            {

            }

            else if (num == 2)
            {

            }

            else if (num == 3)
            {


            }

            else if (num == 4)
            {

            }

            else
            {

            }







        }




    }
}
