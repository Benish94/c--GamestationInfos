using System;

class Nes : IConsole
{
    public string Name { get; } = "Nintendo Entertainment System";
    public string Manufacturer { get; } = "Nintendo";
    public int ReleaseYear { get; } = 1985;
    public int Bit { get; } = 8;

    public void ShowInfo()
    {
        Console.WriteLine("{0,-15} {1}", "Name: " + Name);
        Console.WriteLine("{0,-15} {1}", "Erscheinungsjahr: " + ReleaseYear);
        Console.WriteLine("{0,-15} {1}", "Bit: " + Bit);
        Console.WriteLine("{0,-15} {1}", "Hersteller: " + Manufacturer);
    }
}
