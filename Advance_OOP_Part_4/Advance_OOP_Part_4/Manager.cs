using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance__OOP_Part_4
{
  public class Manager
    {



        public delegate void MachineEvent();


        public static MachineEvent? OnstartMachine, OnstopMachine;




        public static void TriggerOnStart()
        {


            if (OnstartMachine != null)
            {
                Console.WriteLine("Below Machines are starting.........");
                OnstartMachine();
            }




        }


        public static void TriggerOnStop()
        {


            if (OnstartMachine != null)
            {
                Console.WriteLine("Below Machines are stoping.........");
                OnstopMachine();
            }







        }








        }
    }
