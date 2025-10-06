using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23011556_030
{
    internal class Class4
    {
        public void Sum()
        {
            Console.WriteLine("\n\t Q#4 Sum of natural numbers ");
            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            for(int i = 1; i < num; i++)
            {
                result = result + i;
            }
            Console.WriteLine($"The sum from 1 to {num} is {result}");
        }
    }
}
