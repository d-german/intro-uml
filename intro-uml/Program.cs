using intro_uml;

var circle = new Circle(5)
{
    Position = new Point { X = 10, Y = 10 }
};

Console.WriteLine(circle.Area());
circle.Draw();
Console.WriteLine(circle.Position);
