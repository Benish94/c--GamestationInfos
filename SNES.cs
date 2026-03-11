using System;

public class SNES : IConsole
{
    public string Name { get; } = "Super Nintendo Entertainment System";
    public int ReleaseYear { get; } = 1990;
    public int Bit { get; } = 16;
    public string Manufacturer { get; } = "Nintendo";
    public int Stock { get; set; } = 88;

    public void ShowInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Erscheinungsjahr: " + ReleaseYear);
        Console.WriteLine("Bit: " + Bit);
        Console.WriteLine("Hersteller: " + Manufacturer);
    }
    public void ShowStock()
    {
        Console.WriteLine("Lagerbestand: " + Stock);
    }
}