using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Part_3
{
    public static class ClientCode
    {



        public static void UseAdapter()
        {

            string[,] employeesArray = new string[3, 2]
            {



            {"Sajib","30000" },
            {"Sunny","300000" },
            {"Tisha","3000" }

            };


            Console.WriteLine("Process Salary");
            IAdapter employee = new EmployeeAdapter();
            employee.AdapMatrixData(employeesArray);


        }

         







    }
}
