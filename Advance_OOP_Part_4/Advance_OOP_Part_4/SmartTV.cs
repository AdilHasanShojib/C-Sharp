using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance__OOP_Part_4
{
   public class SmartTV
    {


        public string TVName { set; get; }


        public SmartTV(string tVName)
        {
            TVName = tVName;
            Manager.OnstartMachine += StartMachine;
            Manager.OnstopMachine += StopMachine;
        }




        private void StartMachine()
        {
            Console.WriteLine($"{TVName} has started!");
        }


        private void StopMachine()
        {
            Console.WriteLine($"{TVName} has stopped!");
        }
















    }
}
