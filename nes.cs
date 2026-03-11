using System;
using Gamestation_Info;

class Nes : IConsole
{
    public string Name { get; } = "Nintendo Entertainment System";
    public string Manufacturer { get; } = "Nintendo";
    public int ReleaseYear { get; } = 1983;
    public int Bit { get; } = 8;

    public int Stock { get; set; } = 100;

    public void ShowStock()
    {
        Console.WriteLine("Stock: " + Stock);
    }

    public void ShowInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Hersteller: " + Manufacturer);
        Console.WriteLine("Erscheinungsjahr: " + ReleaseYear);
        Console.WriteLine("Bit: " + Bit);
    }
}
