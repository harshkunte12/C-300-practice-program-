using System addingnumebers;
class Program {
    static void Main() {
        int sum = 0;
        // Add numbers from 1 to 10
        for(int i=1; i<=10; i++) {
            sum += i;
        }
        Console.WriteLine("Sum = " + sum);
    }
}