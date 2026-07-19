using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    public static void Main(string[] args)
    {
        UserManager userManager = new UserManager();
        userManager.GetuserData();
        userManager.DisplayResults();

    }
}
class UserManager
{
    public string userName;
    public int userNumber;
    public void GetuserData()
    {
        Console.Write("Enter Your name:");
        userName = Console.ReadLine();

        Console.Write("Enter an integer :");
        userNumber = Convert.ToInt32(Console.ReadLine());
    }
    public void DisplayResults()
    {
        Console.WriteLine("\n___Results___");
        Console.WriteLine("UserName: " + userName);
        Console.WriteLine("Integer Rows:");
        for (int i = 1; i <= 5; i++) 
        {
            Console.WriteLine(userNumber);
        }
        Console.WriteLine("___________");
    }
}