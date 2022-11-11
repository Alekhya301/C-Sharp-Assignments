using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] alekhya = new int[5];
            for(int i = 0; i < alekhya.Length; i++)
            {
                Console.WriteLine(" Enter array elements:",alekhya[i]);
                Console.ReadLine();
                
            }
            Console.WriteLine(" sorted array list :");
            Array.Sort(alekhya);
            foreach (int i in alekhya)
            {
                Console.WriteLine(i + " ");
            }
        }
    }
}
