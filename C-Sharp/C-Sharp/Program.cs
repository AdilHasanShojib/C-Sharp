﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //Console.WriteLine("Hello,World!");
    //        //var userName = Console.ReadLine();
    //        //Console.WriteLine("Username:" + userName);
    //        //var password = Console.ReadLine();
    //        //Console.WriteLine("Password:" + password);
    //        //Console.ReadKey();


    //        //Value Type
    //        //int ageTisha = 17;
    //        //int ageSajib;
    //        //ageSajib = ageTisha;
    //        //ageTisha = 24;
    //        //Console.WriteLine("Tisha is "+ageTisha+" years old");
    //        //Console.WriteLine("Sajib is "+ageSajib+" years old");
    //        //Console.Read();


    //        //Reference Type
    //        //int[] arr = { 1, 2, 3 };
    //        //int[] arr2 = arr;
    //        //Console.WriteLine("arr[0]="+arr[0]);
    //        //Console.WriteLine("arr2[0]=" + arr2[0]);
    //        //arr[0] = 60;
    //        //Console.WriteLine("arr[0]= " + arr[0]);
    //        //Console.WriteLine("arr2[0]=" + arr2[0]);
    //        //Console.ReadKey();

    //        //int num1 = 30;
    //        //int num2 = 50;
    //        //int sum = num1 + num2;
    //        //Console.WriteLine("num1:{0} + num2:{1} = sum: {2}",num1,num2,sum);
    //        //Console.ReadKey();

    //        //precision

    //        //float singlePrecision = 1.342273324738749387298f;
    //        //double doublePrecision = 3.14161722173732732732732837237d;
    //        //decimal higherPrecision = 112213232166;


    //        //Console.WriteLine("num1:{0},num2:{1},num3: {2}", singlePrecision,doublePrecision,higherPrecision);
    //        //Console.ReadKey();

    //    }
    //}


    //public enum DayOfWeek // Enumeration Type (enum)
    //{

    //    Monday,
    //    Tuesday,
    //    Wednesday,
    //    Thursday,
    //    Friday,
    //    Saturday,
    //    Sunday
    //}

    //public class DaysOfWeek
    //{

    //    static void Main(string[] args)
    //    {
    //      DayOfWeek today= DayOfWeek.Friday;

    //        if (today == DayOfWeek.Friday || today==DayOfWeek.Saturday)
    //        {
    //            Console.WriteLine("It is weekend!");
    //        }

    //        else
    //        {
    //            Console.WriteLine("It is weekday");
    //        }

    //        Console.ReadKey();


    //    }



    struct Point
    {

        public int X;
        public int Y;
    }

    public class Coordinates
    {
        static void Main(string[] args)
        {

            Point P;
            P.X = 6;
            P.Y = 9;
            //        Console.WriteLine("pointer coordinates: x:{0},y:{1}",P.X,P.Y);
            //        Console.Read();

            Console.WriteLine("Point Coordinates: X:{0},Y:{1}",P.X,P.Y);
            Console.ReadLine();


            


        }



    }















}
