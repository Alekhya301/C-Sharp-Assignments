using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class AssignQ1
    {
        static void Main(string[] args)

        {
            int Result;
            Console.WriteLine("Enter first number");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter any Operator(+,-,*,/)");
            string Operator = Console.ReadLine();



            if (Operator == "+")
            {
                Result = a + b;
                Console.WriteLine("Result = {0}", a + b);
            }
            else if (Operator == "-")
            {
                Result = a - b;
                Console.WriteLine("Result = {0}", a - b);
            }
            else if (Operator == "*")
            {
                Result = a * b;
                Console.WriteLine("Result = {0}", a * b);
            }
            else if (Operator == "/")
            {
                Result = a / b;
                Console.WriteLine("Result = {0}", a / b);
            }

            else
            {
                Console.WriteLine("Given Operator is not Present");
            }






        }
    }
}
