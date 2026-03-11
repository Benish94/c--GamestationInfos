using System;
using System.Reflection.Metadata;



public class PSX : IConsole
{

    public string Name { get; } = "PlayStation 1";
    public int ReleaseYear { get; } = 1994;
    public int Bit { get; } = 32;
    public string Manufacturer { get; } = "Sony";

    public int Stock { get; set; } = 100;

    public void ShowStock()
    {
        Console.WriteLine("Stock: " + Stock);
    }
    public void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Release Year: {ReleaseYear}");
        Console.WriteLine($"Bit: {Bit}");
        Console.WriteLine($"Manufacturer: {Manufacturer}");
    }

}



