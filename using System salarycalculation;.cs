using System salarycalculation;
class Program {
    static void Main() {
        double basic = 20000;
        double hra = basic * 0.2; // 20% HRA
        double da = basic * 0.1;  // 10% DA
        double gross = basic + hra + da;
        Console.WriteLine("Gross Salary = " + gross);
    }
}