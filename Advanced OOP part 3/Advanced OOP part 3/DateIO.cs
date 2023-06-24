using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_OOP_part_3
{
    internal class DateIO
    {

        public static void CheckDate()
        {

            //DateTime dt = new DateTime(2003,8,17);
            //Console.WriteLine(dt);
            //Console.WriteLine(DateTime.Today);
            //Console.WriteLine(DateTime.Now);
            //Console.WriteLine(DateTime.UtcNow);
            //Console.WriteLine(DateTime.Today.DayOfWeek);


            //DateTime tomorrow = GetTomorrow();
            //Console.WriteLine(tomorrow.DayOfWeek);

            Console.WriteLine("Write DOB like this : yyyy-mm-dd");
            var input = Console.ReadLine() ?? "1999-6-16";

            var life = BirthDateCount(input);

            if(life > 0)
            {
                Console.WriteLine($"You are Alive {life} Days");
            }
            else
            {
                Console.WriteLine("Write Right formate");
            }

        }


        public static DateTime GetTomorrow() { 
        
            
            return DateTime.Today.AddDays(1);


        }

        public static int BirthDateCount(string Input)
        {   DateTime dateTime = DateTime.Now;
            DateTime tm;
            if(DateTime.TryParse(Input, out tm))
            {
                Console.WriteLine(tm);
                TimeSpan days=dateTime.Subtract(tm);
                return days.Days;
            }

            else { return 0; }
        }


        
    }
}
