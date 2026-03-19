using Xunit;
using GeometryShape;

namespace GeometryShape.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void CreateTriangle_ValidData_Success()
        {
            var tri = new Triangle(3, 4, 5);
            Assert.NotNull(tri);
        }

        [Fact]
        public void Perimeter_CalculatedCorrectly()
        {
            var tri = new Triangle(3, 4, 5);
            Assert.Equal(12, tri.Perimeter());
        }

        [Fact]
        public void Area_CalculatedCorrectly()
        {
            var tri = new Triangle(3, 4, 5);
            Assert.Equal(8, tri.Area());
        }

        [Fact]
        public void CreateTriangle_InvalidData_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 10));
        }
    }
}