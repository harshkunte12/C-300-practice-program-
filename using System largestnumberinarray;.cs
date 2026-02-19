using System largestnumberinarray;
class Program {
    static void Main() {
        int[] arr = {10, 25, 5, 40};
        int max = arr[0];
        // Find largest element
        foreach(int x in arr) {
            if(x > max) max = x;
        }
        Console.WriteLine("Largest = " + max);
    }
}