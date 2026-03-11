using System;

public class NintendoDS : IConsole, IStockManager
{
    public string Name { get; set; } = "Nintendo DS";
    public int ReleaseYear { get; set; } = 2004;
    public int Bit { get; set; } = 32;
    public string Manufacturer { get; set; } = "Nintendo";

    private int _stock = 100;
    int IStockManager.Stock { get => _stock; set => _stock = value; }

    void IStockManager.ShowStock()
    {
        Console.WriteLine("Aktueller Lagerbestand: {0} Stück", _stock);
    }

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
}
