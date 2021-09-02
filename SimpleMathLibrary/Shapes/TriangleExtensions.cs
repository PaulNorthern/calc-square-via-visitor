using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMathLibrary.Shapes
{
    public static class TriangleExtensions
    {
        /// <summary>
        /// Calculates the area using the Heron formula.
        /// </summary>
        /// <param name="triangle"></param>
        /// <returns></returns>
        public static bool isRightTriangle(this Triangle triangle)
        {
            return Math.Pow(triangle.a, 2) + Math.Pow(triangle.b, 2) == Math.Pow(triangle.c, 2) ||
                   Math.Pow(triangle.a, 2) + Math.Pow(triangle.c, 2) == Math.Pow(triangle.b, 2) ||
                   Math.Pow(triangle.b, 2) + Math.Pow(triangle.c, 2) == Math.Pow(triangle.a, 2); 
        }
    }
}
