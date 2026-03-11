using System;

class PlayStation4 : IConsole
{
    public string Name { get; } = "PlayStation 4";
    public int ReleaseYear { get; } = 2013;
    public int Bit { get; } = 64;
    public string Manufacturer { get; } = "Sony";

    public void ShowInfo()
    {
        Console.WriteLine("{0,-15} {1}", "Name: " + Name);
        Console.WriteLine("{0,-15} {1}", "Erscheinungsjahr: " + ReleaseYear);
        Console.WriteLine("{0,-15} {1}", "Bit: " + Bit);
        Console.WriteLine("{0,-15} {1}", "Hersteller: " + Manufacturer);
    }
}
