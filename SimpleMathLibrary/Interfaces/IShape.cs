using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMathLibrary.Interfaces
{
    public interface IShape
    {
        void Accept(IVisitor visitor);
    }
}
