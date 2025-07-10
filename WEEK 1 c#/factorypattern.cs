//Factory Pattern

using System;

interface IShape
{
    void Draw();
}

class Circle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a Circle");
    }
}

class Square : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a Square");
    }
}

class Rectangle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a Rectangle");
    }
}

class ShapeFactory
{
    public IShape CreateShape(string type)
    {
        if (type == null)
        {
            return null;
        }

        switch (type.ToLower())
        {
            case "circle":
                return new Circle();
            case "square":
                return new Square();
            case "rectangle":
                return new Rectangle();
            default:
                throw new ArgumentException("Unknown shape type: " + type);
        }
    }
}

class FactoryPatternDemo
{
    static void Main(string[] args)
    {
        ShapeFactory factory = new ShapeFactory();

        IShape shape1 = factory.CreateShape("circle");
        shape1.Draw();

        IShape shape2 = factory.CreateShape("square");
        shape2.Draw();

        IShape shape3 = factory.CreateShape("rectangle");
        shape3.Draw();
    }
}