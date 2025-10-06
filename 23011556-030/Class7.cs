using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23011556_030
{
    internal class Class7
    {
        public void Reverse()
        {
            Console.WriteLine("\n\t Q#7 Revesing digits");
            Console.WriteLine("Enter a number:");
            int numb = Convert.ToInt32(Console.ReadLine());
            int reverse = 0; 
            while (numb > 0)
            {
                int digit = numb % 10;
                reverse = reverse * 10 + digit;
                numb /= 10;
            }
            Console.WriteLine($"The reversed number is {reverse}");
        }
    }
}
