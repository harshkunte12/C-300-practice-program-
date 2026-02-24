using System starpattern;
class Program {
    static void Main() {
        // Print simple triangle pattern
        for(int i=1; i<=5; i++) {
            for(int j=1; j<=i; j++) {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}