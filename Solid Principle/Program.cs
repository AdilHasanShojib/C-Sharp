namespace Solid_Principle
{
  public class Program
    {
        static void Main(string[] args)
        {
            //var invoice = new Invoices("Dummy", "Dummy Description", 4);
            //invoice.AddInvoice();
            var ammount = InvoiceOC.GetInvoiceDiscount(50000.00, Invoicetype.FinalInvoice);
            Console.WriteLine(ammount);

            //AppleBase app = new OrangeDerived();
                                                  //----------violate Liskove
            //Console.WriteLine(app.GetColor());



            IFruit fruit = new AppleBase();
            Console.WriteLine(fruit.GetColor());
        }
    }
}