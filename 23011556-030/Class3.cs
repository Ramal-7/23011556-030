using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23011556_030
{
    internal class Class3
    {
        public void Grade()
        {
            Console.WriteLine("\n\t Q#3 Grade evaluation  \n");
            Console.WriteLine("Enter marks obtained: ");
            int marks = Convert.ToInt32(Console.ReadLine());
            if (marks >= 85)
            {
                Console.WriteLine("Grade : A ");
            }
            else if(marks >=70 && marks <= 84)
            {
                Console.WriteLine("Grade : B ");
            }
            else if(marks >= 55 && marks <= 69)
            {
                Console.WriteLine("Grade : C ");
            }
            else if(marks >=40 && marks <= 54)
            {
                Console.WriteLine("Grade : D ");
            }
            else
            {
                Console.WriteLine("Grade : F ");
            }
        }
    }
}
