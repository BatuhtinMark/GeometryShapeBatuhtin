using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryShape
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            if (width <= 0 || height <= 0)
            {
                throw new ArgumentException("Длины сторон должны быть положительны");
            }
            Width = width;
            Height = height;
        }

        public override double Area() => Width * Height;
        public override double Perimeter() => (Width + Height) * 2;
        public override string ToString() => $"Прямоугольник: {Width}x{Height}";
    }
}