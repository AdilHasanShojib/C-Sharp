using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle
{
    public class Invoices
    {

        public string InvoiceName { get; set; }

        public string InvoiceDescription { get; set; }
        public int OrderId { get; set; }
        private email EmailSender;
        private ILoggerSRP logger;



        public Invoices(string invoiceName, string invoiceDescription, int orderId)
        {
            InvoiceName = invoiceName;
            InvoiceDescription = invoiceDescription;
            OrderId = orderId;
            EmailSender = new email();
            this.logger = new Logger();




        }
        public void AddInvoice()
        {
            try
            {
                Console.WriteLine("Your invoice is Creating");

                if (!string.IsNullOrEmpty(InvoiceName)) Console.WriteLine("Invoice is read to send");
                MailMessage mailMessage = new MailMessage("Email From", "Email TO", "Invoice", "Your Invoice body");
                this.EmailSender.SendEmail(mailMessage);
            }

            catch (Exception ex) { Console.WriteLine(ex.Message); }

        }



        public void SendEmail(MailMessage mailMessage)
        {

            try
            {
                Console.WriteLine("EMAIL IS SENDING");
                Console.WriteLine("email has send");
            }


            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
        }


        public void DeleteInvoice(MailMessage mailMessage)
        {
            try
            {
                Console.WriteLine("your invoice is deleting");
                if (string.IsNullOrEmpty(InvoiceName)) Console.WriteLine("Invoice is deleted");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }




    }
}
