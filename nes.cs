using System;

class Nes : IConsole
{
    public string Name { get; set; } = "Nintendo Entertainment System";
    public string Manufacturer { get; set; } = "Nintendo";
    public int ReleaseYear { get; set; } = 1983;
    public int Bit { get; set; } = 8;

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