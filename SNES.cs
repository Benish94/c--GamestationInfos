using System;

class SNES : IConsole
{
    public string Name { get; set; } = "Super Nintendo Entertainment System";
    public int ReleaseYear { get; set; } = 1990;
    public int Bit { get; set; } = 16;
    public string Manufacturer { get; set; } = "Nintendo";

    private int stock = 100;

    public void ShowInfo()
    {
        Console.WriteLine("");
        Console.WriteLine("Informationen zur Konsole:");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("");
        Console.WriteLine("{0,-15} {1}", "Name:", Name);
        Console.WriteLine("{0,-15} {1}", "Release Year:", ReleaseYear);
        Console.WriteLine("{0,-15} {1}", "Bit:", Bit);
        Console.WriteLine("{0,-15} {1}", "Manufacturer:", Manufacturer);
        Console.WriteLine("");
    }

    public void ShowStock()
    {
        Console.WriteLine("Aktueller Lagerbestand: {0} Stück", stock);
    }
}