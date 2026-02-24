using System gradecalculation;
class Program {
    static void Main() {
        int marks = 72;
        if(marks >= 90) Console.WriteLine("Grade A");
        else if(marks >= 75) Console.WriteLine("Grade B");
        else if(marks >= 50) Console.WriteLine("Grade C");
        else Console.WriteLine("Grade D");
    }
}