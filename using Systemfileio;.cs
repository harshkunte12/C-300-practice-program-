using Systemfileio;
using System.IO;
class Program {
    static void Main() {
        string path="test.txt";
        using(StreamWriter sw=new StreamWriter(path)){
            sw.WriteLine("Hello File");
        }
        using(StreamReader sr=new StreamReader(path)){
            Console.WriteLine(sr.ReadToEnd());
        }
    }
}