using System daysintomonth;
class Program {
    static void Main() {
        int days = 400;
        int years = days / 365;
        int months = (days % 365) / 30;
        int remainingDays = (days % 365) % 30;
        Console.WriteLine($"{days} days = {years} years, {months} months, {remainingDays} days");
    }
}