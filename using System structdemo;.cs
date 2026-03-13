using System structdemo;
struct Point {
    public int X, Y;
    public Point(int x, int y) { X = x; Y = y; }
}
class Program {
    static void Main() {
        Point p = new Point(10, 20);
        Console.WriteLine($"Point = ({p.X},{p.Y})");
    }
}