using System reversenumber;
class Program {
    static void Main() {
        int n = 1234, rev = 0;
        // Reverse digits of number
        while(n > 0) {
            rev = rev*10 + n%10;
            n /= 10;
        }
        Console.WriteLine("Reverse = " + rev);
    }
}