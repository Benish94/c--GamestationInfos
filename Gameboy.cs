using System;

class Gameboy : IConsole
{
    public string Name { get; } = "Nintendo Game Boy";
    public int ReleaseYear { get; } = 1989;
    public int Bit { get; } = 8;
    public string Manufacturer { get; } = "Nintendo";

    public void ShowInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Erscheinungsjahr: " + ReleaseYear);
        Console.WriteLine("Bit: " + Bit);
        Console.WriteLine("Hersteller: " + Manufacturer);
    }
}