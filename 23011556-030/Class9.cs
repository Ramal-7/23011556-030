using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace _23011556_030
{
    internal class Class9
    {
        public void CheckinArray()
        {
            Console.WriteLine("\n\t Q#9 Check even odd in array");
            int[] numbers = new int[10];
            int even = 0;
            int odd = 0;
            Console.WriteLine("Enter 10 numbers for array");
            for( int i= 0; i < numbers.Length; i++)
            {
              numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            Console.WriteLine($"There are {even} even numbers in array");
            Console.WriteLine($"There are {odd} odd numbers in array");
        }
    }
}
