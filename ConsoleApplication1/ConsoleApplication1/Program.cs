using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////task1
            //Console.WriteLine("enter first number:");
            //double num1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("enter second number:");
            //double num2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("enter third number:");
            //double num3 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("enter fourth number:");
            //double num4 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("enter fifth number:");
            //double num5 = Convert.ToDouble(Console.ReadLine());
            //double avg = (num1 + num2 + num3 + num4 + num5) / 5;
            //Console.WriteLine("the average of five numbers is " + avg);

            ////task2
            //Console.WriteLine("Circle");
            //Console.WriteLine("Enter radius of circle");
            //double r = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Area of Circle: "+ (22/7) * r * r);
            //Console.WriteLine("Triangle");
            //Console.WriteLine("Enter length of triangle:");
            //double l = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter breath of triangle:");
            //double b = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Area of Triangle: " + (l * b)/2);

            ////task3
            //Console.WriteLine("Input a String:");
            //string input = Console.ReadLine();
            //string output = "";
            //for (int i = input.Length - 1; i >= 0; i--)
            //{
            //    output = output + input[i];
            //}
            //Console.WriteLine("The Reverse string is :" + output);

            //string name = "Hello World";
            //for (int i = 0; i < 11; i++)
            //{
            //    Console.WriteLine(name);
            //}

            //task4
            for (int i = 1; i <=5 ; i++)
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write(j + " ");                
                }
                for (int k = 2; k <=(6-i); k++)
                {
                    Console.Write(k + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
