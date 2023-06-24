using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Advanced_OOP_part_3
{
    internal class REX
    {
        public static void VerifyEmail()
        {
            string emailREX = @"/^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\\.[a-zA-Z0-9-]+)*$/";

            Regex rx = new Regex(emailREX, RegexOptions.Compiled);
            string myEmail = "test_tech-byte.de";
            string Email = "sajibtalukder115@gmail.com";

            Match match = rx.Match(Email);

            if (match.Success)
            {
                Console.WriteLine("Valid Email!");

            }
            else
            {
                Console.WriteLine("Not Valid");
            }

        }

    }
}
