namespace Advanced_OOP_Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAnimal[] animals =
            {
                new Bird (),
                new Dog (),
                new Cat (),
            };

            foreach (IAnimal animal in animals)
            {
                animal.Makesound();
                animal.Move();

            }







        }
    }
}