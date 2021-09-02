using SimpleMathLibrary.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMathLibrary.Interfaces
{  
    public interface IVisitor
    {
        void visit(Triangle triangle);
        void visit(Circle circle);      
    }
}
