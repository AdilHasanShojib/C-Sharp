namespace Basic_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //Array 3D

            string[,,] array3d = {

                {

                    { "Shojib","sunny","Anamul","Adil" },
                    {
                      "Sunny,","Shojib","Arefin","Tisha"
                    }

                },



                {

                    { "Shojib","Emel","Joy","Adil" },
                    {"Anan,","Arab","Arefin","Tisha"}

                },

               





            };


            Console.WriteLine(array3d.Rank);
            Console.WriteLine(array3d.Length);
           // Console.WriteLine($"The value is{array3d[1,2,3]}");




















        }
    }
}