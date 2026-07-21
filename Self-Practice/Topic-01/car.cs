using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class car
{
    public string model;
    public string color;
    public int year;

    public void fullThrottle()
    {
        Console.WriteLine("The car is going full throttle!");
    }
}
class Program
{
    public static void Main(string[] args)
    {
        car Ford = new car();
        Ford.model = "Mustang";
        Ford.color = "red";
        Ford.year = 1969;

        car Opel = new car();
        Opel.model = "Astra";
        Opel.color = "blue";
        Opel.year = 2005;

        Console.WriteLine($"{Ford.model} , {Ford.color}, {Ford.year}");

    }

}