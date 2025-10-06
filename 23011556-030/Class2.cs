using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _23011556_030
{
    internal class Class2
    {
       public void Calculator()
        {
            Console.WriteLine("\n\t Q#2 Simple calculator \n");
            Console.WriteLine("Enter 1st number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Addition +");
            Console.WriteLine("2. Subtraction -");
            Console.WriteLine("3. Multiplication *");
            Console.WriteLine("4. Division /");
            Console.WriteLine("Enter your choice (1-4): ,");
            int Choice = Convert.ToInt32(Console.ReadLine());
            int result = 0;

           switch (Choice)
            {
                case 1:
                    result = a + b;
                    Console.WriteLine($"Result : {a} + {b} = {result}");
                    break;
                case 2:
                    result = a - b;
                    Console.WriteLine($"Result : {a} - {b} = {result}");
                    break;
                case 3:
                    result = a * b;
                    Console.WriteLine($"Result : {a} * {b} = {result}");
                    break;
                case 4:
                    if (b == 0)
                    { 
                        Console.WriteLine("Division by zero is not allowed");
                    }
                    else
                    {
                        result = a / b;
                        Console.WriteLine($"Result : {a} / {b} = {result}");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice! please select from 1-4");
                    break;
            }

        }
    }
}
