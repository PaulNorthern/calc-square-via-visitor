using SimpleMathLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMathLibrary.Shapes
{
    public class Triangle : IShape
    {
        public double a, b, c;
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.visit(this);
        }
    }
}
