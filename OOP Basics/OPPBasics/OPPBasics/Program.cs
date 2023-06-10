namespace OPPBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Car audi = new Car(Color.Blue,"Audi-500","Audi",DateTime.Now.AddYears(-10));
            //Car bmw = new Car(Color.Yellow, "BMW-2", "BMW");
            Car marcedez = new Car();
            //audi.color = Color.Red;
            //Console.WriteLine(audi.color);

            //int bmw = Car.price;
            //bmw = 4;
            //Console.WriteLine(bmw);
            //bmw.Start();
            //audi.Start();
            //audi.Speed();
            //bmw.Speed();
            //bmw.CarDetails();

            marcedez.setname("Marcedez-500");
            marcedez.Start();


        }
    }
}