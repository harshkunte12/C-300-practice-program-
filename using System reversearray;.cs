using System reversearray;
class Program {
    static void Main() {
        int[] arr = {1, 2, 3, 4, 5};
        Array.Reverse(arr);
        Console.WriteLine("Reversed Array: " + string.Join(",", arr));
    }
}