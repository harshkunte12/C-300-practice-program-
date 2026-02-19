using System shapeinheritance;
abstract class Shape {
    public abstract double Area();
}
class Circle:Shape {
    double r;
    public Circle(double radius){ r=radius; }
    public override double Area(){ return Math.PI*r*r; }
}
class Rectangle:Shape {
    double l,w;
    public Rectangle(double length,double width){ l=length; w=width; }
    public override double Area(){ return l*w; }
}
class Program {
    static void Main() {
        Shape c=new Circle(5);
        Shape r=new Rectangle(4,6);
        Console.WriteLine("Circle Area: "+c.Area());
        Console.WriteLine("Rectangle Area: "+r.Area());
    }
}