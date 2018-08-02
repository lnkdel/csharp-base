using System;

namespace DesignPatterns
{
    public interface Shape
    {
        void Draw();
    }

    public class Rectangle : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Rectangle::draw() method.");
        }
    }

    public class Square : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Square::draw() method.");
        }
    }

    public class Circle : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Circle::draw() method.");
        }
    }

    public class ShapeFactory
    {
        public Shape GetShape(string shapeType)
        {
            if (string.IsNullOrEmpty(shapeType))
                return null;
            if (shapeType.ToUpper().Equals("CIRCLE"))
                return new Circle();
            else if (shapeType.ToUpper().Equals("RECTANGLE"))
                return new Rectangle();
            else if (shapeType.ToUpper().Equals("SQUARE"))
                return new Square();
            return null;
        }
    }

    
}
