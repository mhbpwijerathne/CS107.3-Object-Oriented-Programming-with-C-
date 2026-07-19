using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Vehicle
{
    string brand;
    int no_wheels;
    string sound;

    public Vehicle(string brand, int no_wheels, string sound)
    {
        this.brand = brand;
        this.no_wheels = no_wheels;
        this.sound = sound;
    }

    public void set_brand(string brand)
    {
        this.brand = brand;
    }

    public string get_brand()
    {
        return brand;
    }

    public void set_no_wheels(int no_wheels)
    {
        this.no_wheels = no_wheels;
    }

    public int get_no_wheels()
    {
        return no_wheels;
    }

    public void set_sound(string sound)
    {
        this.sound = sound;
    }

    public string get_sound()
    {
        return sound;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        
        var bus = new Vehicle("AL", 6, "Honk");

        
        Console.WriteLine(bus.get_sound());
    }
}
