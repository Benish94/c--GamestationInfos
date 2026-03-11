using System;

class PlayStation4 : IConsole
{
    public string Name { get; } = "PlayStation 4";
    public int ReleaseYear { get; } = 2070;
    public int Bit { get; } = 42;
    public string Manufacturer { get; } = "Sony";

    public int Stock { get; set; } = 100;

    public void ShowStock()
    {
        Console.WriteLine("Stock: " + Stock);
    }
    public void ShowInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Erscheinungsjahr: " + ReleaseYear);
        Console.WriteLine("Bit: " + Bit);
        Console.WriteLine("Hersteller: " + Manufacturer);
    }
}
