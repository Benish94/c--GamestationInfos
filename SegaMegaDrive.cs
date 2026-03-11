using System;

public class SegaMegaDrive : IConsole
{
    public string Name { get; } = "Sega Mega Drive";
    public int ReleaseYear { get; } = 1988;
    public int Bit { get; } = 16;
    public string Manufacturer { get; } = "Sega";

    public void ShowInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Erscheinungsjahr: " + ReleaseYear);
        Console.WriteLine("Bit: " + Bit);
        Console.WriteLine("Hersteller: " + Manufacturer);
    }
}
