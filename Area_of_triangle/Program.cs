using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calculate Area of triangle.
            // Take suer input for base
            // Take user input for Height 
            // Run calculation and output area.
            // areaOfTriangle = .5 * base * height 
            Console.WriteLine("Welcome to my Area of Triangle Calculator");
            Console.WriteLine("Please enter the length of the base: ");
            double triBase = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the length of the heights: ");
            double triHeight = double.Parse(Console.ReadLine());
            double areaOfTri = .5 * triBase * triHeight;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"The are of the triangle is: {areaOfTri}");
          

            Console.ReadLine();
        }
    }
}
