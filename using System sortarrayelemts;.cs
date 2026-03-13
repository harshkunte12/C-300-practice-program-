using System sortarrayelemts;
class Program {
    static void Main() {
        int[] arr = {5, 2, 8, 1};
        Array.Sort(arr);
        Console.WriteLine("Sorted Array: " + string.Join(",", arr));
    }
}