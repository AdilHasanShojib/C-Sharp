using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance__OOP_Part_4
{
    public class WashingMachine
    {


        public string WMName { set; get; }


        public WashingMachine(string name)
        {


            WMName = name;
            Manager.OnstartMachine += StartMachine;
            Manager.OnstopMachine += StopMachine;


        }


        private void StartMachine()
        {
            Console.WriteLine($"{WMName} has started!");
        }


        private void StopMachine()
        {
            Console.WriteLine($"{WMName} has stopped!");
        }




















    }
}
