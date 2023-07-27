using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_2
{
    public static class ClientCodeForUsingPrototype
    {

        public static void useprototype()
        {


            student sunny= new student();
            sunny.Name = "Anamul Sani";
            sunny.Department = "police";
            sunny.University = "Police Training";
            

            student sajib = sunny.GetClone();
            sajib.Name = "Shojib Talukder";
            sajib.University = "uiu";
            sajib.Department = "CSE";


            Console.WriteLine($"Name: {sunny.Name} Department : {sunny.Department} University : {sunny.University} ");

            Console.WriteLine($"Name: {sajib.Name} Department : {sajib.Department} University : {sajib.University} ");


        }







    }
}
