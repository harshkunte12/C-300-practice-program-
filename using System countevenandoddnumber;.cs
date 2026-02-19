using System countevenandoddnumber;
class Program {
    static void Main() {
        int[] arr = {1,2,3,4,5,6};
        int even = 0, odd = 0;
        // Count even and odd
        foreach(int x in arr) {
            if(x % 2 == 0) even++;
            else odd++;
        }
        Console.WriteLine("Even = " + even + ", Odd = " + odd);
    }
}