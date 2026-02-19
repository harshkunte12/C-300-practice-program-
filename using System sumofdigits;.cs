using System sumofdigits;
class Program {
    static void Main() {
        int n = 123, sum = 0;
        // Add digits of number
        while(n > 0) {
            sum += n % 10;
            n /= 10;
        }
        Console.WriteLine("Sum of digits = " + sum);
    }
}