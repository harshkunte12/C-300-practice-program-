using System sumandavgofarray;
class Program {
    static void Main() {
        int[] arr = {10, 20, 30, 40};
        int sum = 0;
        foreach(int x in arr) sum += x;
        double avg = (double)sum / arr.Length;
        Console.WriteLine($"Sum = {sum}, Average = {avg}");
    }
}