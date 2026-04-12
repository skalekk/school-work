using System;
using System.Reflection;
using System.Collections.Generic;
class Vechicle
{
    public string brand;
    public int speed;
    public void Go()
    {
        Console.WriteLine("Auto się porusza");
    }

    public virtual void Showinfo()
    {
        Console.Write($"Marka: {brand} Prędkość: {speed}");
    }

    public Vechicle(string brand_in, int speed_in)
    {
        brand = brand_in;
        speed = speed_in;
    }
}

class Bycicle : Vechicle
{
    public string BycicleInfo;
    public override void Showinfo()
    {
        base.Showinfo();
        Console.Write($" Informacje: {BycicleInfo}");
    }

    public Bycicle(string brand_in, int speed_in, string BycicleInfo_in)
    : base(brand_in, speed_in)
    {
        BycicleInfo = BycicleInfo_in;
    }
}

class Car : Vechicle
{
    public string CarInfo;

    public override void Showinfo()
    {
        base.Showinfo();
        Console.Write($" Informacje: {CarInfo}");
    }
    public Car(string brand_in, int speed_in, string CarInfo_in)
    : base(brand_in, speed_in)
    {
        CarInfo = CarInfo_in;
    }
}
class MainClass
{
    static void Main(string[] args)
    {
        List<Vechicle> Vechicley = new List<Vechicle>();
        Bycicle bmx = new Bycicle("Bmx", 100, "do a flip or smth");
        Car germans = new Car("Volkswagen", 300, "mmmmmmmmmmmmmmmmmmmmm german car they made cars for the controvertial guy from what i know very silly");
        Vechicley.Add(bmx);
        Vechicley.Add(germans);
        foreach (Vechicle p in Vechicley)
        {
            p.Showinfo();
            Console.WriteLine($"\n");
        }

    }
}