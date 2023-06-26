namespace Advanced_OOP_part_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DateIO.CheckDate();
            //REX.VerifyEmail();

            //BuildInterface SE = new BuildInterface(120);

            //BuildInterface ML= new BuildInterface(1220);

            //Console.WriteLine(SE.Equals(ML));


            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] arr = { 1, 2, 3, 4, };
            //IEnumerable.CollectionSum(list);
            IEnumerable.CollectionSum(arr);



        }
    }
}