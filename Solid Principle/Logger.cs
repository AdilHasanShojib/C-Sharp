using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle
{
    public class Logger : ILoggerSRP
    {
        void ILoggerSRP.Debug(string Info)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Info);
        }

        void ILoggerSRP.Error(string message, Exception ex)
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message, ex.ToString());
        }

        void ILoggerSRP.Info(string Info)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Info);



        }
    }
}
