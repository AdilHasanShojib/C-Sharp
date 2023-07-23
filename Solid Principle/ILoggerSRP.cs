using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle
{
 public interface ILoggerSRP
    {
        void Info(string Info);
        void Debug(string Info);
        void Error(string message, Exception ex);


    }
}
