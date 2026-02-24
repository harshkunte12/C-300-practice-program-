using System sumofnaturalnumbers;
class Program {
    static void Main() {
        int n = 10, sum = 0;
        for(int i=1; i<=n; i++) sum += i;
        Console.WriteLine("Sum of first 10 natural numbers = " + sum);
    }
}