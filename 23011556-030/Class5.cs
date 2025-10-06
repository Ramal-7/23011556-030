using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23011556_030
{
    internal class Class5
    {
        public void Table()
        {
            Console.WriteLine("\n\t Q#5 Multiplication Table ");
            Console.WriteLine("Enter number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int result;
            for (int i = 0; i <= 10; i++)
            {
                result = num * i;
                Console.WriteLine($"{num} * {i} = {result}");
            }
        }
    }
}