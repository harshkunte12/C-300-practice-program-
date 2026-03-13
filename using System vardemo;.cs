using System vardemo;
class Program {
    static void Main() {
        var a = 10; // type inferred as int
        dynamic b = "Hello"; // type decided at runtime
        Console.WriteLine($"var a = {a}, dynamic b = {b}");
    }
}