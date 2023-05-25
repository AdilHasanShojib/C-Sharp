using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello,World!");
            //var userName = Console.ReadLine();
            //Console.WriteLine("Username:" + userName);
            //var password = Console.ReadLine();
            //Console.WriteLine("Password:" + password);
            //Console.ReadKey();


            //Value Type
            //int ageTisha = 17;
            //int ageSajib;
            //ageSajib = ageTisha;
            //ageTisha = 24;
            //Console.WriteLine("Tisha is "+ageTisha+" years old");
            //Console.WriteLine("Sajib is "+ageSajib+" years old");
            //Console.Read();


            //Reference Type
            int[] arr = { 1, 2, 3 };
            int[] arr2 = arr;
            Console.WriteLine("arr[0]="+arr[0]);
            Console.WriteLine("arr2[0]=" + arr2[0]);
            arr[0] = 60;
            Console.WriteLine("arr[0]= " + arr[0]);
            Console.WriteLine("arr2[0]=" + arr2[0]);
            Console.ReadKey();


        }
    }
}
