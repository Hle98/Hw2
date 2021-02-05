using System;

namespace Hw2
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Intersection of 2 lines
            //double a1, a2, b1, b2, c1, c2, d, x, y;
            //Console.Write("Enter a1: ");
            //a1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter b1: ");
            //b1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter c1: ");
            //c1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter a2: ");
            //a2 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter b2: ");
            //b2 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter c2: ");
            //c2 = Convert.ToDouble(Console.ReadLine());
            //d = a1 * b2 - a2 * b1;
            //x = ((c1 * b2 - c2 * b1) / d);
            //y = ((a1 * c2 - a2 * c1) / d);
            //if (d != 0)
            //{
            //    Console.WriteLine($"Two lines have intersection point at: ({x},{y})");
            //}
            //else
            //{
            //    Console.WriteLine("Two lines parallel");
            //}

            //Area of Triangle

            //double x1, x2, x3, y1, y2, y3, A;
            //Console.WriteLine("Hi people, I'm Triangle Area Calculator. Follow me!!!");
            //Console.Write("Enter x1: ");
            //x1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter y1: ");
            //y1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter x2: ");
            //x2 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter y2: ");
            //y2 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter x3: ");
            //x3 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter y3: ");
            //y3 = Convert.ToDouble(Console.ReadLine());
            //A = 0.5 * ((x1 - x2) * (y1 - y3) - (x1 - x3) * (y1 - y2));
            //if ((x1 == x2 & x2 == x3) ||
            //    (y1 == y2 & y2 == y3) ||
            //    (x1 == x2 & y1 == y2) ||
            //    (x1 == x3 & y1 == y3) || (x2 == x3 & y2 == y3))
            //{
            //    Console.WriteLine("Three points that you entered couldn't form any triangle. Please try other points ");
            //}
            //else
            //{
            //    Console.WriteLine($"The area of the triangle is: {Math.Abs(A)} square units.");
            //}  

            //double a1, a2, a3, b1, b2, b3, c1, c2, c3, d12, d13, d23, x1, x2, x3, y1, y2, y3, A;
            //Console.Write("Enter a1: ");
            //a1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter b1: ");
            //b1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter c1: ");
            //c1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter a2: ");
            //a2 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter b2: ");
            //b2 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter c2: ");
            //c2 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter a3: ");
            //a3 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter b3: ");
            //b3 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter c3: ");
            //c3 = Convert.ToDouble(Console.ReadLine());

            //d12 = a1 * b2 - a2 * b1;
            //x1 = ((c1 * b2 - c2 * b1) / d12);
            //y1 = ((a1 * c2 - a2 * c1) / d12);

            //d13 = a1 * b3 - a3 * b1;
            //x2 = (c1 * b3 - c3 * b1) / d13;
            //y2 = (a1 * c3 - a3 * c1) / d13;

            //d23 = a2 * b3 - a3 * b2;
            //x3 = (c2 * b3 - c3 * b2) / d23;
            //y3 = (a2 * c3 - a3 * c2) / d23;

            //A = 0.5 * ((x1 - x2) * (y1 - y3) - (x1 - x3) * (y1 - y2));

            //if (d12 == 0 || d13 == 0 || d23 == 0)
            //{
            //    Console.WriteLine("Two of three lines parallel, so we don't have any triangle.");
            //}
            //else if (x1 == x2 & x2 == x3 & y1 == y2 & y2 == y3)
            //{
            //    Console.WriteLine("Three intersection points are not distinct, so we don't have any triangle.");
            //}
            //else
            //{
            //    Console.WriteLine($"The area of the triangle is: {Math.Abs(A)} square units");

            //}
            
            for (int i=3; i<=6; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine($"{i}x{j} = {i * j}");
                }
                Console.WriteLine();
            }
            



        }
    }
}
