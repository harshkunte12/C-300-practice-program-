using System;
class Student {
    public string Name;
    public int Roll;
    public Student(string name,int roll){
        Name=name; Roll=roll;
    }
    public void Display(){
        Console.WriteLine("Name: "+Name+", Roll: "+Roll);
    }
}
class Program {
    static void Main() {
        Student s1=new Student("Harsh",101);
        s1.Display();
    }
}