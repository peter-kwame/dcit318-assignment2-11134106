using System;

namespace AbstractClassDemo
{
    // Abstract base class Shape
    abstract class Shape
    {
        // Abstract method to get area
        public abstract double GetArea();
    }

    // Derived class Circle
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        // Implement GetArea() for circle
        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    // Derived class Rectangle
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        // Implement GetArea() for rectangle
        public override double GetArea()
        {
            return Width * Height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create Circle and Rectangle instances
            Circle circle = new Circle(5);
            Rectangle rectangle = new Rectangle(4, 6);

            // Display their areas
            Console.WriteLine($"Circle area: {circle.GetArea():F2}");
            Console.WriteLine($"Rectangle area: {rectangle.GetArea():F2}");
        }
    }
}
