﻿using System;

namespace Employee
{
    class Program
    {
        public static void Main(string[] args)
        {
            int isFullTime = 1;
         
            Random random = new Random();//Random object has next method to gernerate random numbers
            int empCheck = random.Next(0, 2);//generates 0 1 2
            if (empCheck == isFullTime)
            {
                Console.WriteLine("Employee is present");
               
            }
            else
            {
                Console.WriteLine("Employee is absent");
              
            }
          
        }
    }
}
