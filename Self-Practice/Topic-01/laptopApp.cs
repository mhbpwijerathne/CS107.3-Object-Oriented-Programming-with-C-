using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopApp
{
    class Laptop
    {
        public string brand = "HP";
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Laptop myLaptop = new Laptop();
            Console.WriteLine(myLaptop.brand);
            Console.ReadLine();

        }


    }
}
