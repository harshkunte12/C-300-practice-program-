using System enumdemo;
enum Days { Mon, Tue, Wed, Thu, Fri, Sat, Sun }
class Program {
    static void Main() {
        Days today = Days.Wed;
        Console.WriteLine("Today is " + today);
    }
}