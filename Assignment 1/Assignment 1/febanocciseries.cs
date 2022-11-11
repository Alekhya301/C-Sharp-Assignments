using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class febanocciseries
    {
        public static void Main()
        {
            int a=0, b=0, c, num;
            Console.WriteLine("Enter the number:");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a + "" + b + "");
            
            for(c = 0; c<num; c++)
            {
                c = a + b;
                Console.WriteLine("c={0]", c);
                a = b;
                b = c;


            }
        }
    }
}
