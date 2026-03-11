using System;
using System.Text.Json.Serialization;

public class Konsole : IConsole, IStockManager
{
    public string Name { get; set; }
    public int ReleaseYear { get; set; }
    public int Bit { get; set; }
    public string Manufacturer { get; set; }

    public int Stock { get; set; } = 100;
    int IStockManager.Stock { get => Stock; set => Stock = value; }
    void IStockManager.ShowStock()
    {
        Console.WriteLine($"Aktueller Lagerbestand von Konsole {Name}: {Stock} Stück");
    }

    public void ShowInfo()
    {
        Console.WriteLine("");
        Console.WriteLine("Infromationen zur Konsole:");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("");
        Console.WriteLine($"{nameof(Name),-15} {Name}");
        Console.WriteLine($"{nameof(ReleaseYear),-15} {ReleaseYear}");
        Console.WriteLine($"{nameof(Bit),-15} {Bit}");
        Console.WriteLine($"{nameof(Manufacturer),-15} {Manufacturer}");
        Console.WriteLine("");
    }
}
