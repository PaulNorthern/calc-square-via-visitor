using SimpleMathLibrary;
using SimpleMathLibrary.Interfaces;
using SimpleMathLibrary.Shapes;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var geometry = new Geometry();

            var circle = new Circle(5);        
            Console.WriteLine($"{circle.GetType().Name} square is {geometry.area(circle)}");

            var triangle = new Triangle(3, 4, 5);
            Console.WriteLine($"{triangle.GetType().Name} square is {geometry.area(triangle)}");
            Console.WriteLine($"Is Rectangle right? - {triangle.isRightTriangle()}");
        }        
    }
}
