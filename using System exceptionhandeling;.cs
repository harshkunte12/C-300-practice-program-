using System exceptionhandeling;
class Program {
    static void Main() {
        try {
            int a=10,b=0;
            Console.WriteLine(a/b);
        }
        catch(DivideByZeroException e){
            Console.WriteLine("Error: "+e.Message);
        }
        finally {
            Console.WriteLine("Finally block executed");
        }
    }
}