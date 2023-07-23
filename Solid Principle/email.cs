using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle
{
    public class email
    {

        public string EmailFrom { get; set; }
        public string EmailTo { get; set; }
        public string EmailSubject { get; set; }
        public string EmailBody { get; set; }


        public void SendEmail(MailMessage mailMessage)
        {


            try
            {
                Console.WriteLine("EMAIL IS SENDING");
                Console.WriteLine("email has send");
            }

            catch (Exception ex) {


                Console.WriteLine(ex.ToString());
            }   


        }














    }
}
