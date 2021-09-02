using Moq;
using SimpleMathLibrary.Shapes;
using SimpleMathLibrary.Interfaces;
using Xunit;

namespace SimpleMathLibrary.Tests
{
    public class AreaVisitorTest
    {
        private Mock<IVisitor> _visitor;
        
        public AreaVisitorTest()
        {
            _visitor = new Mock<IVisitor>();        
        }

        [Fact]
        public void visit_for_triangle_works()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);
            _visitor.Setup(x => x.visit(triangle)).Verifiable();

            // Act
            var geometry = new Geometry();
            var res = geometry.area(triangle);

            // Assert
            Assert.Equal(6, res);
            
        }

        [Fact]
        public void visit_for_circle_works()
        {
            // Arrange
            var circle = new Circle(5);
            _visitor.Setup(x => x.visit(circle)).Verifiable();

            // Act
            var geometry = new Geometry();
            var res = geometry.area(circle);

            // Assert
            Assert.Equal(79, Convert.ToInt32(res));

        }


        [Fact]
        public void isRightTriangle_calculate_true()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);
            _visitor.Setup(x => x.visit(triangle)).Verifiable();

            // Act         
            var res = triangle.isRightTriangle();

            // Assert
            Assert.True(res);
        }

        [Fact]
        public void isRightTriangle_calculate_false()
        {
            // Arrange
            var triangle = new Triangle(1, 2, 9);
            _visitor.Setup(x => x.visit(triangle)).Verifiable();

            // Act         
            var res = triangle.isRightTriangle();

            // Assert
            Assert.True(!res);
        }
    }
}
