using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance__OOP_Part_4
{
   public class Oven
    {
           public string OvenName { set; get; }


            public Oven(string Name)
            {
                OvenName = Name;
                Manager.OnstartMachine += StartMachine;
                Manager.OnstopMachine += StopMachine;
            }




            private void StartMachine()
            {


            Console.WriteLine($"{OvenName} has started!");
            
            }


        private void StopMachine()
        {
            Console.WriteLine($"{OvenName} has stopped!");
        }










    }











}

