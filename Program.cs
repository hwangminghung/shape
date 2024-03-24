public abstract class Shape
{
    public string Color { get; set; }
    public bool Filled { get; set; }

    public Shape()
    {
        Color = "green";
        Filled = true;
    }

    public Shape(string color, bool filled)
    {
        Color = color;
        Filled = filled;
    }

    public abstract double GetArea();
    public abstract double GetPerimeter();

    public override string ToString()
    {
        return $"A Shape with color of {Color} and {(Filled ? "filled" : "not filled")}";
    }
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle()
    {
        Radius = 1.0;
    }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }

    public override double GetPerimeter()
    {
        return 2 * Math.PI * Radius;
    }

    public override string ToString()
    {
        return $"A Circle with radius={Radius}, which is a subclass of {base.ToString()}";
    }
}

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Length { get; set; }

    public Rectangle()
    {
        Width = 1.0;
        Length = 1.0;
    }

    public Rectangle(double width, double length)
    {
        Width = width;
        Length = length;
    }

    public override double GetArea()
    {
        return Width * Length;
    }

    public override double GetPerimeter()
    {
        return 2 * (Width + Length);
    }

    public override string ToString()
    {
        return $"A Rectangle with width={Width} and length={Length}, which is a subclass of {base.ToString()}";
    }
}

public class Square : Rectangle
{
    public double Side
    {
        get { return Width; }
        set { Width = Length = value; }
    }

    public Square()
    {
        Side = 1.0;
    }

    public Square(double side)
    {
        Side = side;
    }

    public override string ToString()
    {
        return $"A Square with side={Side}, which is a subclass of {base.ToString()}";
    }
}