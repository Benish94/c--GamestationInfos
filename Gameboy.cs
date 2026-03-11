using System;

class Gameboy : IConsole
{
    public string Name { get; } = "Gameboy";
    public int ReleaseYear { get; } = 1989;
    public int Bit { get; } = 8;
    public string Manufacturer { get; } = "Nintendo";

    public int Stock { get; set; } = 100;

    public void ShowInfo()
    {
        Console.WriteLine("");
        Console.WriteLine("Infromationen zur Konsole:");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("");
        Console.WriteLine("{0,-15} {1}", "Name:", Name);
        Console.WriteLine("{0,-15} {1}", "Release Year:", ReleaseYear);
        Console.WriteLine("{0,-15} {1}", "Bit:", Bit);
        Console.WriteLine("{0,-15} {1}", "Manufacturer:", Manufacturer);
        Console.WriteLine("");
    }

    public void ShowStock()
    {
        Console.WriteLine("Stock: " + Stock);
    }
}
