using System powerofnumber;
class Program {
    static void Main() {
        int baseNum = 2, exp = 5;
        double result = Math.Pow(baseNum, exp);
        Console.WriteLine($"{baseNum}^{exp} = {result}");
    }
}