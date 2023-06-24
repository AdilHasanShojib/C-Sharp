namespace Advanced_OOP_part_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DateIO.CheckDate();
            //REX.VerifyEmail();

            BuildInterface SE = new BuildInterface(120);

            BuildInterface ML= new BuildInterface(1220);

            Console.WriteLine(SE.Equals(ML));


        }
    }
}