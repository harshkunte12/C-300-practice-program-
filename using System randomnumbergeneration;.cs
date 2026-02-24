using System randomnumbergeneration;
class Program {
    static void Main() {
        Random rnd = new Random();
        // Generate 5 random numbers
        for(int i=0; i<5; i++) {
            Console.WriteLine(rnd.Next(1, 100));
        }
    }
}