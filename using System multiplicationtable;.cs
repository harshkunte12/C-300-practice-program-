using System multiplicationtable;
class Program {
    static void Main() {
        int n = 5;
        for(int i=1;i<=10;i++)
            Console.WriteLine(n + " x " + i + " = " + (n*i));

        int num = 7;
        if(num%2==0) Console.WriteLine("Even");
        else Console.WriteLine("Odd");

        switch(num%2){
            case 0: Console.WriteLine("Even via switch"); break;
            default: Console.WriteLine("Odd via switch"); break;
        }
    }
}