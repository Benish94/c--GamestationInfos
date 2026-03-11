using System;

public class PSX : IConsole
{
    public string Name { get; } = "PlayStation 1";
    public int ReleaseYear { get; } = 1994;
    public int Bit { get; } = 32;
    public string Manufacturer { get; } = "Sony";

    public void ShowInfo()
    {
        Console.WriteLine("{0,-15} {1}", "Name: " + Name);
        Console.WriteLine("{0,-15} {1}", "Erscheinungsjahr: " + ReleaseYear);
        Console.WriteLine("{0,-15} {1}", "Bit: " + Bit);
        Console.WriteLine("{0,-15} {1}", "Hersteller: " + Manufacturer);
    }
}
