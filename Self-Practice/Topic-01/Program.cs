using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopApp
{
    class Fruit
    {
        public string name = "Apple";
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Fruit myFruit = new Fruit();
            Console.WriteLine(myFruit.name);
            Console.ReadLine();

        }


    }
}
