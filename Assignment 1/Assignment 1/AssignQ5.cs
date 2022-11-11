using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class AssignQ5
    {
        class Circle
        {
            static float PI = 3.141F;
            int Radius;

            public Circle(int Radius)
            {
                this.Radius = Radius;
            }

            public float CaluculateArea()
            {
                return Circle.PI * this.Radius * this.Radius;
            }

            public float CalculateCircumference()
            {
                return 2 * Circle.PI * this.Radius;
            }
        }
            class Program
            {
                public static void Main()
                {
                    Circle C1 = new Circle(5);
                    float Area = C1.CaluculateArea();
                    Console.WriteLine("Area= {0}", Area);

                    Circle C2 = new Circle(9);
                    float Circumference = C2.CalculateCircumference();
                    Console.WriteLine("Circumference= {0}", Circumference);
                }
            }



        
    }
}

