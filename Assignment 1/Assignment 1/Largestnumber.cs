using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Largestnumber
    {
        public static void Main()
        {
            int a, b;
            Console.WriteLine("Enter first number:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            b = Convert.ToInt32(Console.ReadLine());

            if(a > b)
            {
                Console.WriteLine("Largest number = {0}", a);

            }
            else
            {
                Console.WriteLine("Largest number = {0}", b);
            }
            Console.ReadLine();
        }
    }
}
