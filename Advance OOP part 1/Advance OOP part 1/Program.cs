namespace Advance_OOP_part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Duck duck = new Duck("Donald","Black","fish");
            //duck.Fly();
            //duck.Eat();

            VIP vip = new VIP("sunny", 2, 269);
            VIP vip2 = new VIP("shojib", 2, 269);

            Titanic titanic = new Titanic("wax", 20000, 400000);

            titanic.SinkAllabe.Add(vip);
            titanic.SinkAllabe.Add(vip2);

            titanic.sink();











        }
    }
}