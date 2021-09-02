using SimpleMathLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMathLibrary.Shapes
{
    public class AreaVisitor : IVisitor
    {
        public double area;

        public void visit(Circle circle)
        {           
            try
            {
                area = Math.PI * Math.Pow(circle.radius, 2);
            }
            catch (Exception)
            {
                throw;
            }          
        }

        public void visit(Triangle triangle)
        {
            double p;
            try
            {
                p = (triangle.a + triangle.b + triangle.c) / 2;
            }          
            catch (Exception)
            {
                throw;
            }
            
            area = Math.Sqrt(p * (p - triangle.a) * (p - triangle.b) * (p - triangle.c));
        }     
    }
}
