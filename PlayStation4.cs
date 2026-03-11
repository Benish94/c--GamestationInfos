using System;

class PlayStation4 : IConsole
{
    public string Name { get; } = "PlayStation 4";
    public int ReleaseYear { get; } = 2013;
    public int Bit { get; } = 64;
    public string Manufacturer { get; } = "Sony";

    public void ShowInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Erscheinungsjahr: " + ReleaseYear);
        Console.WriteLine("Bit: " + Bit);
        Console.WriteLine("Hersteller: " + Manufacturer);
    }
}
