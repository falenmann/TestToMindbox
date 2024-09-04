using System;
using Xunit;

namespace TestToMindbox
{
    public class UnitTest
    {
        [Fact]
        public void CircleAreaTest()
        {
            var circle = new Circle(5);
            Assert.Equal(Math.PI * 25, circle.CalculateArea(), 5);
        }

        [Fact]
        public void TriangleAreaTest()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.Equal(6, triangle.CalculateArea(), 5);
        }

        [Fact]
        public void TriangleIsRightTriangleTest()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.True(triangle.IsRightTriangle());
        }

        [Fact]
        public void RectangleAreaTest()
        {
            var rectangle = new Rectangle(4, 5);
            Assert.Equal(20, rectangle.CalculateArea());
        }
    }
}