using System polymorphism;
interface IEmployee {
    void Work();
}
class Manager:IEmployee {
    public void Work(){ Console.WriteLine("Manager managing work"); }
}
class Developer:IEmployee {
    public void Work(){ Console.WriteLine("Developer coding"); }
}
class Program {
    static void Main() {
        IEmployee emp1=new Manager();
        IEmployee emp2=new Developer();
        emp1.Work();
        emp2.Work();
    }
}