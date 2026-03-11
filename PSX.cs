using System;

public class PSX : IConsole
{
    public string Name { get; } = "PlayStation 1";
    public int ReleaseYear { get; } = 1994;
    public int Bit { get; } = 32;
    public string Manufacturer { get; } = "Sony";

    public void ShowInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Erscheinungsjahr: " + ReleaseYear);
        Console.WriteLine("Bit: " + Bit);
        Console.WriteLine("Hersteller: " + Manufacturer);
    }
}
