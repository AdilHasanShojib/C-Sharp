using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMethod
{
    public class ConvertToUpper
    {

        public void Nametoupper()
        {
            string takeInput = null;
            Console.WriteLine("Please Enter valid String :");
            takeInput=Console.ReadLine();
            int result = 0;
            while(Int32.TryParse(takeInput, out result)){ 
               
                Console.WriteLine("Type String Value:-");
                takeInput = Console.ReadLine();

            
            
            
            }
            string myString = null;

            if (!string.IsNullOrWhiteSpace(takeInput)) { 

                myString = takeInput.ToUpper();
                Console.WriteLine($"You converted to name to upper {myString}");
            
                
            
            
            }
            else
            {
                Console.WriteLine("You have added Into empty value");
            }


            Console.ReadKey();


        }







    }
}
