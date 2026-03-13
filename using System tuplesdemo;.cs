using System tuplesdemo;
class Program {
    static void Main() {
        var person = (Name: "Harsh", Age: 21);
        Console.WriteLine($"Name = {person.Name}, Age = {person.Age}");
    }
}