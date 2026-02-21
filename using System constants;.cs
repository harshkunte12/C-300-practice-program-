using System constants;
class Demo {
    public const double Pi = 3.14; // compile-time
    public readonly int MyValue;   // runtime
    public Demo(int val) {
        MyValue = val;
    }
}
class Program {
    static void Main() {
        Demo d = new Demo(100);
        Console.WriteLine($"Const Pi = {Demo.Pi}, Readonly = {d.MyValue}");
    }
}