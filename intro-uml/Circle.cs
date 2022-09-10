namespace intro_uml;

public class Circle : Shape
{
    private readonly double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public override double Area()
    {
        return Math.PI * _radius * _radius;
    }

    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}
