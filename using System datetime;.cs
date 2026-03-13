using System datetime;
class Program {
    static void Main() {
        DateTime now = DateTime.Now;
        Console.WriteLine("Current Date & Time = " + now);
        Console.WriteLine("Today = " + now.ToShortDateString());
        Console.WriteLine("Time = " + now.ToShortTimeString());
    }
}