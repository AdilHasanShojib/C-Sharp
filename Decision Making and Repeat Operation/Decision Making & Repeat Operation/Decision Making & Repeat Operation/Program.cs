using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision_Making___Repeat_Operation
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // simple if else Condition 

            int voteCount = 0;
            string result = null;
            voteCount = 10;

            if ( voteCount > 0) {

                Console.WriteLine("Won");

            }

            else { Console.WriteLine("Lost"); }

            var vote = voteCount > 0 ? "Won" : "Lost";
            Console.WriteLine(vote);
            Console.ReadKey();






        }
    }
}
