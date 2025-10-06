using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23011556_030
{
    internal class Class6
    { 
        public void Factorial()
        {
            Console.WriteLine("\n\t Q#6 Factorial of number using while loop ");
            Console.WriteLine("Enter number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            int i = 1;
            while (i <= num)
            {
                fact *= i;
                i++;
            }
            Console.WriteLine($"Factorial of {num} is {fact}");
        }
    }
}
