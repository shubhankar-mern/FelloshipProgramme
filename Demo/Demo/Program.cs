using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    class Program
    {
        public static void Main(string[] args)
        {
            calculator obj1 = new calculator();
            
            char consent = 'y';
            while (consent=='y')
            {
                
                Console.WriteLine("Enter choice 1-4");
                int key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        Console.WriteLine("Enter 2 nums");
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        int sum = obj1.getsum(num1, num2);
                        Console.WriteLine("Sum is "+sum);
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("Enter 2 nums");
                        int num3 = Convert.ToInt32(Console.ReadLine());
                        int num4 = Convert.ToInt32(Console.ReadLine());
                        int div = obj1.getdiv(num3, num4);
                        Console.WriteLine("Division is "+div);
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Enter 2 nums");
                        int num5 = Convert.ToInt32(Console.ReadLine());
                        int num6 = Convert.ToInt32(Console.ReadLine());
                        int mul = obj1.getmul(num5, num6);
                        Console.WriteLine("Multiply is "+mul);
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("Enter 2 nums");
                        int num7 = Convert.ToInt32(Console.ReadLine());
                        int num8 = Convert.ToInt32(Console.ReadLine());
                        int dif = obj1.getdif(num7, num8);
                        Console.WriteLine("Difference is "+dif);
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Please Enter Input 1-4");
                        break;

                }
                Console.WriteLine("Continue...y/n");
                char ch = Convert.ToChar(Console.ReadLine());
                consent = ch;
            }

        }
    }
}