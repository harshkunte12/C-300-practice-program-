using System largestandsmallestelementinarray;
class Program {
    static void Main() {
        int[] arr = {10, 25, 5, 40};
        int max = arr[0], min = arr[0];
        foreach(int x in arr) {
            if(x > max) max = x;
            if(x < min) min = x;
        }
        Console.WriteLine($"Largest = {max}, Smallest = {min}");
    }
}