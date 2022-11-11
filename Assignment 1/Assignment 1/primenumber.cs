using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class primenumber
    {
        public static void Main()
        {
            int  num;
            Console.WriteLine("Enter the Number:");
            num = Convert.ToInt32(Console.ReadLine());

            if(num%2 == 0)
            {
                Console.WriteLine("given number is not prime");
            }
            else
            {
                Console.WriteLine("given number is prime");
            }
        }
    }
}
