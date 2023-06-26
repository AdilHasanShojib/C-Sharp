using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_OOP_part_3
{
    internal class Delegate0
    {  


        public delegate bool FilterDelegate(EventDelegate e);
        public static void CheckDelegate()
        {

            List<string> list = new List<string> { "Sunny", "Shojib", "Emel", "raiyan" };
            list.RemoveAll(filter);

            foreach (string s in list)
            {
                Console.WriteLine(s);
            }

           

        }

        public static void Display(string s,List<EventDelegate> list, FilterDelegate f)
        {

            Console.WriteLine(s);

            foreach (var e in list)
            {
                if (f(e))
                {
                    Console.WriteLine("{0} {1} years old",e.name,e.age);
                }

            }
        }

          

        public static bool filter(string s)
        {

            return s.Contains("i");
        }


        public static void DelegateExamople()
        {
            EventDelegate e1 = new EventDelegate { name = "SHOJIB", age = 24 };
            EventDelegate e2 = new EventDelegate { name = "SANI", age = 20 };
            EventDelegate e3 = new EventDelegate { name = "TISHA", age = 17 };
            EventDelegate e4 = new EventDelegate { name = "REHIA", age = 55 };

            List<EventDelegate> list = new List<EventDelegate>() { e1,e2,e3,e4 };

            Display("Kids", list, IsAdult);
        }

        public static bool IsAdult(EventDelegate e)
        {

            return e.age >= 18;
        }

        public static bool IsSenior(EventDelegate e)
        {

            return e.age >= 50;
        }

        public static bool IsMinor(EventDelegate e)
        {

            return e.age <18;
        }


    }
}
