using System nullable;
class Program {
    static void Main() {
        int? x = null;
        Console.WriteLine(x.HasValue ? x.Value.ToString() : "Value is null");
    }
}