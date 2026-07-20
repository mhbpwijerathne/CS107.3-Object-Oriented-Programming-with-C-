using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Student
{
    public string name;
    public int age;
    public void DisplayDetails()
    {
        Console.WriteLine($"Student Name:{name},Age:{age}");
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Student student1 = new Student();
        student1.name = "Harsha wijerathne";
        student1.age = 23;
        student1.DisplayDetails();

    }
}
