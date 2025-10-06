using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23011556_030
{
    internal class Class1
    {
        public void Run()
        {
            Console.WriteLine("\n\t Q#1 Check even odd");
            Console.WriteLine(" Enter Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Number " + num + " is even");
            }
            else
            {
                Console.WriteLine("Number " + num + " is odd");
            }
        }
    }
}
