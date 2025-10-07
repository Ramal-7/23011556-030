using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23011556_030
{
    internal class Class10
    {
        public void Search()
        {
            Console.WriteLine("\n\t Q#10 Searching in array ");
            int[] Array = { 12, 14, 17, 18, 20, 22, 26, 34, 29, 7 };
            Console.WriteLine("Enter a number to search: ");
            int search = Convert.ToInt32(Console.ReadLine());
            bool found = false;
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] == search)
                {
                    Console.WriteLine($"Number {search} is in the array at index {i}");
                    found = true;
                    break;
                }
            }
                if(!found)
                {
                    Console.WriteLine($"Number {search} is not in the array");
                }
        }
    }
}