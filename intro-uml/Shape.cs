namespace intro_uml;

public abstract class Shape : IDrawable
{
    public Point? Position { get; set; }
    public abstract double Area();
    public abstract void Draw();
}
