using System breakandcontinue;
class Program {
    static void Main() {
        for(int i=1; i<=10; i++) {
            if(i == 5) break; // stop loop at 5
            if(i % 2 == 0) continue; // skip even numbers
            Console.WriteLine(i);
        }
    }
}