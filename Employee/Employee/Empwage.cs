using System;
using System.Collections.Generic;
using System.Text;

namespace Employee
{
    class Empwage
    {
        public static void Main(string[] args)
        {
            int isFullTime = 1;
            int empRatePerHour = 20;
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();//Random object has next method to gernerate random numbers
            int empCheck = random.Next(0, 2);//generates 0 1 2
            if (empCheck == isFullTime)
            {
                
                empHrs = 8;
            }
            else
            {
                
                empHrs = 0;
            }
            empWage = empRatePerHour * empHrs;
            Console.WriteLine("Employee has earned " + empWage);
        }
    }
}
