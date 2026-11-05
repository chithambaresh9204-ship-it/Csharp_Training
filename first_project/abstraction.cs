using System;

abstract class Shape
{
    public abstract double Area { get; }
    public abstract void CalculateArea();

    public void DisplayArea()
    {
        Console.WriteLine($"Area: {Area}");
    }
}

class Circle : Shape
{
    private double radius;
    private double calculatedArea;

    public override double Area => calculatedArea;

    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Radius must be positive.");
        this.radius = radius;
        CalculateArea();
    }

    public override void CalculateArea()
    {
        calculatedArea = 3.14 * radius * radius;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Shape: Circle");
        Console.WriteLine($"Radius: {radius}");
        DisplayArea();
    }
}

class Rectangle : Shape
{
    private double length;
    private double width;
    private double calculatedArea;

    public override double Area => calculatedArea;

    public Rectangle(double length, double width)
    {
        if (length <= 0 || width <= 0)
            throw new ArgumentException("Length and width must be positive.");
        this.length = length;
        this.width = width;
        CalculateArea();
    }

    public override void CalculateArea()
    {
        calculatedArea = length * width;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Shape: Rectangle");
        Console.WriteLine($"Length: {length}");
        Console.WriteLine($"Width: {width}");
        DisplayArea();
    }
}

class Triangle : Shape
{
    private double baseLength;
    private double height;
    private double calculatedArea;

    public override double Area => calculatedArea;

    public Triangle(double baseLength, double height)
    {
        if (baseLength <= 0 || height <= 0)
            throw new ArgumentException("Base and height must be positive.");
        this.baseLength = baseLength;
        this.height = height;
        CalculateArea();
    }

    public override void CalculateArea()
    {
        calculatedArea = 0.5 * baseLength * height;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Shape: Triangle");
        Console.WriteLine($"Base: {baseLength}");
        Console.WriteLine($"Height: {height}");
        DisplayArea();
    }
}

class ABSProgram
{
    static void Main()
    {
        Circle circle = new Circle(5);
        circle.DisplayDetails();

        Console.WriteLine();

        Rectangle rectangle = new Rectangle(10, 5);
        rectangle.DisplayDetails();
    }
}