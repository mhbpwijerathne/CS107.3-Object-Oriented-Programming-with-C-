using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    public static void Main(string[] args)
    {
        NameRepeater repeater = new NameRepeater();
        Console.Write("How many times should I print?");
        int count = Convert.ToInt32(Console.ReadLine());
        repeater.PrintName(count);
    }
}
class NameRepeater
{
    public string myName = "Harsha Wijerathne";
    public void PrintName(int times)
    {
        for (int i = 1; i <= times; i++)
        {
            Console.WriteLine(myName);
        }

    }
}
