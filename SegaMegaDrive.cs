using System;

public class SegaMegaDrive
{

    public string Name { get; set; }
    public int ReleaseYear { get; set; }
    public int Bit { get; set; }
    public string Manufacturer { get; set; }

    public int Stock { get; set; } = 100;

    public SegaMegaDrive(string name, int releaseYear, int bit, string manufacturer)
    {
        Name = name;
        ReleaseYear = releaseYear;
        Bit = bit;
        Manufacturer = manufacturer;
    }

    public void ShowStock()
    {
        Console.WriteLine("Stock: " + Stock);
    }

    public void PrintInfo()
    {
        Console.WriteLine("=== SEGA MEGA DRIVE ===");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Erscheinungsjahr: {ReleaseYear}");
        Console.WriteLine($"Bit: {Bit}-Bit");
        Console.WriteLine($"Hersteller: {Manufacturer}");
    }
}
