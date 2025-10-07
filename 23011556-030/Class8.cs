using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23011556_030
{
    internal class Class8
    {
        public void Array()
        {
            int[] arr = { 1, 80, 24, 6, 5, 9, 20, 82, 45, 67 };
            int min = arr[0];
            int max = arr[0];
            for (int i = 1; i<arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("Maximum number in array is " + max);
            Console.WriteLine("Minimum number in array is " + min);
        }
}
