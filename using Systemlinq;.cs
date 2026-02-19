using Systemlinq;
using System.Collections.Generic;
using System.Linq;
class Student {
    public string Name; public int Roll;
    public Student(string n,int r){ Name=n; Roll=r; }
}
class Program {
    static void Main() {
        List<Student> list=new List<Student>{
            new Student("Harsh",101),
            new Student("Amit",102),
            new Student("Ravi",103)
        };
        var result=list.Where(s=>s.Roll>101);
        foreach(var s in result)
            Console.WriteLine(s.Name+" "+s.Roll);
    }
}