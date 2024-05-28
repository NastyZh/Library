using library;

namespace TestLibrary;
[TestFixture]
public class Tests
{
       [Test]
        public void CircleAreaTest()
        {
            IShape circle = ShapeFactory.CreateCircle(10);
            Assert.AreEqual(Math.PI * 100, circle.GetSquare(), 1e-10);
        }

        [Test]
        public void TriangleAreaTest()
        {
            IShape triangle = ShapeFactory.CreateTriangle(3, 4, 5);
            Assert.AreEqual(6, triangle.GetSquare(), 1e-10);
        }

        [Test]
        public void RightTriangleTest()
        {
            Triangle triangle = (Triangle)ShapeFactory.CreateTriangle(3, 4, 5);
            Assert.IsTrue(triangle.IsRightTriangle());
        }

        [Test]
        public void NonRightTriangleTest()
        {
            Triangle triangle = (Triangle)ShapeFactory.CreateTriangle(3, 4, 6);
            Assert.IsFalse(triangle.IsRightTriangle());
        }
    
}