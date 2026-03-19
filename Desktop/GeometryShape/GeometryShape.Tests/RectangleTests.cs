using Xunit;
using GeometryShape;

namespace GeometryShape.Tests
{
    public class RectangleTests
    {
        [Fact]
        public void CreateRectangle_ValidData_Success()
        {
            var rect = new Rectangle(5, 10);
            Assert.NotNull(rect);
        }

        [Fact]
        public void Area_CalculatedCorrectly()
        {
            var rect = new Rectangle(5, 10);
            Assert.Equal(50, rect.Area());
        }

        [Fact]
        public void Perimeter_CalculatedCorrectly()
        {
            var rect = new Rectangle(5, 10);
            Assert.Equal(30, rect.Perimeter());
        }

        [Fact]
        public void CreateRectangle_InvalidData_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => new Rectangle(-5, 10));
            Assert.Throws<ArgumentException>(() => new Rectangle(5, 0));
        }
    }
}