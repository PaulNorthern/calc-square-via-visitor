using SimpleMathLibrary.Interfaces;
using SimpleMathLibrary.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMathLibrary
{
	public class Geometry
	{
		public double area(IShape shape)
		{
			var areaVisitor = new AreaVisitor();
			shape.Accept(areaVisitor);
			return areaVisitor.area;
		}
	}
}
