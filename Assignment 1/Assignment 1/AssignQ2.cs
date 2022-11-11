using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace average_marks
{
    internal class AssignQ2
    {
         public static void Main(string[] args)


        {
            Console.WriteLine("Average Marks of Students:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            int e = Convert.ToInt32(Console.ReadLine());

            int[] Average = { a, b, c, d, e };
            Console.WriteLine("HighestAverage:" + Average.Max());
            Console.ReadLine();














        }
    }
}
