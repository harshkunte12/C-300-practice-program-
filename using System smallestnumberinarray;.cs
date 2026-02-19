using System smallestnumberinarray;
class Program {
    static void Main() {
        int[] arr = {10, 25, 5, 40};
        int min = arr[0];
        // Find smallest element
        foreach(int x in arr) {
            if(x < min) min = x;
        }
        Console.WriteLine("Smallest = " + min);
    }
}