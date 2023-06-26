using Advance__OOP_Part_4;

namespace Advance_OOP_Part_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            



            var Smarttv = new SmartTV("SAMSUNG TV");
            var Smartoven = new Oven("LG OVEN");
           var SmartWM = new WashingMachine("Walton Washing Machine");




            //Smarttv.StartMachine();
            //Smartoven.StartMachine();
            //SmartWM.StartMachine();


            //Console.Read();


            //Smarttv.StopMachine();
            //SmartWM.StopMachine();
            //Smartoven.StopMachine();




            Startall();


            Console.Read();


            Stopall();



        }


        public static void Startall()
        {
            Manager.TriggerOnStart();


        }


        public static void Stopall()
        {


            Manager.TriggerOnStop();

        }







    }
}
