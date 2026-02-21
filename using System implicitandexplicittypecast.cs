using System implicitandexplicittypecasting;
class Program {
    static void Main() {
        int x = 10;
        double y = x; // implicit
        double z = 9.8;
        int w = (int)z; // explicit
        Console.WriteLine($"Implicit: {y}, Explicit: {w}");
    }
}