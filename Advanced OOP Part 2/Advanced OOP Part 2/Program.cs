namespace Advanced_OOP_Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IAnimal[] animals =
            //{
            //    new Bird (),
            //    new Dog (),
            //    new Cat (),
            //};

            //foreach (IAnimal animal in animals)
            //{
            //    animal.Makesound();
            //    animal.Move();

            //}

            //var car = new List <Car>()
            // {
            //      new Audi(500,"RED","A9"),
            //      new BMW(700,"Black","A123")

            // };



            // foreach (var item in car)
            // {

            //     item.Repair();
            //     item.ShowDetails();


            // }

            //Audi ad = new Audi(500,"RED","AM3");
            //ad.ShowDetails();
            //ad.SetDetails(56001, "Shojib");
            //ad.getDetails();


            //AbstractOOP shape = new Cube(1234);
            //shape.SetInfo();



            // Read File

            //string[] file = System.IO.File.ReadAllLines("D:\\SOFTWARE INDUSTRY\\GitHub\\C-Sharp\\Advanced OOP Part 2\\Advanced OOP Part 2\text.txt");

            ////Console.ReadLine();

            //foreach (var line in file)
            //{
            //    Console.WriteLine(line);
            //}


            //Write File
            string[] strings = { "I hate You, I love  you" };

            File.WriteAllLines("D:\\SOFTWARE INDUSTRY\\GitHub\\C-Sharp\\Advanced OOP Part 2\\Advanced OOP Part 2\text.txt", strings);







        }
    }
}