﻿using System;
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

            //int voteCount = 0;
            //string result = null;
            //voteCount = 10;

            //if ( voteCount > 0) {

            //    Console.WriteLine("Won");

            //}

            //else { Console.WriteLine("Lost"); }

            //var vote = voteCount > 0 ? "Won" : "Lost";
            //Console.WriteLine(vote);
            //Console.ReadKey();


            //Multi Nested if else

            //if(voteCount > 0 )
            //{
            //    if( voteCount%2==0 ) {

            //        Console.WriteLine($"{voteCount} is a Even Number ");

            //       }

            //    else { Console.WriteLine($"{voteCount} is a Odd Number ");

            //    }




            //}

            //else if (voteCount < 0) {
            //    Console.WriteLine("Neg Number");


            //}



            //else
            //{
            //    Console.WriteLine("Zero Number");

            //}

            //var vote = voteCount > 0 ? voteCount % 2 == 0 ? " Pos Even Number " : "Pos Neg Number": voteCount < 0 ? "Neg Number" : "Zero Number" ; 
            //Console.WriteLine(vote);





            // Multi Branching

            //  string grade = "";

            //  if( voteCount >= 90 )
            //  {
            //      grade = "Outstanding";


            //  }

            //else  if (voteCount >=80)
            //  {

            //      grade = "good";

            //  }

            //  else if (voteCount >= 70)
            //  {

            //      grade = "Average";

            //  }

            //  else if (voteCount >= 60)
            //  {

            //      grade = " Below Average";

            //  }

            //  else
            //  {

            //      grade = "Bad Performer";

            //  }



            //var grade = voteCount >= 90 ? "Outstanding" : voteCount >= 80 ? "good" : voteCount >= 70 ? "Average" : voteCount >= 60 ? "Below Average" : "Bad Performer";

            //Console.WriteLine(grade);



            //Null Coalescing

            //string name = null;
            //string myname = name ?? "Shojib";

            //Console.WriteLine($"My NAME IS {myname}");
            //Console.ReadKey();


            //Nesting Loop

            //for(int i = 2; i >=0; i--)
            //{
            //    for(int j = 0; j <=2; j++)
            //    {


            //        if(i == j)
            //        {
            //            Console.WriteLine("1");
            //        }


            //        else
            //        {
            //            Console.WriteLine("0");
            //        }


            //    }

            //    Console.WriteLine("\n");
            //    Console.ReadKey();



            //}


            //String Reversal

            //string mystring = "Hello World";
            //string reverse = "";

            //for(int i =mystring.Length-1;i>=0;i--)
            //{
            //    reverse += mystring[i];





            //}

            //Console.WriteLine(reverse);
            //   Console.ReadKey();

            //string[] palindrome = { "maam", "sir", "madam", "teacher", "mom", "level", "world" };


            //foreach (string word in palindrome)
            //{
            //    bool ans = true;

            //    for (int i=0; i<word.Length/2; i++)
            //    {

            //        if (word[i] != word[word.Length-1-i])
            //        {
            //            ans= false;
            //            break;
            //        }



            //    }

            //    Console.WriteLine($"{word} is {(ans ? "a palindrome" : "Not Palindrome")} ");



            //}

            int i = 0;
            do
            {
                if (i % 2 != 0)
                {
                   
                    Console.WriteLine(i);

                    Console.ReadKey();
                }

                if (i == 7)
                {
                    break;

                }
                i++;
            } while (i <= 10);








        }
    }
}
