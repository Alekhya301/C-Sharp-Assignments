using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class SwapingofNumbers
    {
        public static void Main()
        {
            int c;

            Console.WriteLine("Enter first number:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int b = Convert.ToInt32(Console.ReadLine());

            c = a;
            a = b;
            b = c;
            Console.WriteLine("After Swapping:");
            Console.WriteLine("First number = {0}", a);
            Console.WriteLine("Second number = {0}", b);
            Console.ReadLine();
        









        }
    }
}