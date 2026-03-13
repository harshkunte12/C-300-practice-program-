using System leapyear;
class Program {
    static void Main() {
        int year = 2024;
        if((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
            Console.WriteLine($"{year} is Leap Year");
        else
            Console.WriteLine($"{year} is Not Leap Year");
    }
}