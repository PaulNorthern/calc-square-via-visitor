using SimpleMathLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMathLibrary.Shapes
{
    public class Circle : IShape
    {
        public double radius { get; set; }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.visit(this);
        }
    }
}
