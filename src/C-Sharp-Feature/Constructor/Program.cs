abstract class Shape
{
    public const double pi = Math.PI;
    protected double x, y;
    public Shape(double x, double y)
    {
        this.x = x;
        this.y = y;
    }
    public abstract double Area();
}
class Circle : Shape  //pi * x * x;      + (2 * pi * x * y)      Cylinder 
{
    public Circle(double radius) : base(radius, 0)
    {

    }
    public override double Area()
    {
        return pi * x * x;
    }
}
class Cylinder : Circle
{
    public Cylinder(double radius, double height) : base(radius)
    {
        y = height;
    }
    public override double Area()
    {
        return (2 * base.Area()) + (2 * pi * x * y);
    }
}

class Example
{
    static void Main(string[] args)
    {
        double radius = 2.5;
        double height = 3.0;
        var ring = new Circle(radius);
        //Console.WriteLine($"{ring.Area():F2}");
        Console.WriteLine($"{ring.Area():F2}");

        var tube = new Cylinder(radius, height);
        Console.WriteLine($"{tube.Area():F2}");

    }
}