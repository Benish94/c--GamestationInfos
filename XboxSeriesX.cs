public class XboxSeriesX : IConsole
{
    public string Manufacturer { get; } = "Microsoft";
    public string Name { get; } = "Xbox Series X";
    public int ReleaseYear { get; } = 2020;
    public int Bit { get; } = 64;

    public int Stock { get; set; } = 100;

    public void ShowStock()
    {
        Console.WriteLine("Stock: " + Stock);
    }
    public void ShowInfo()
    {
        Console.WriteLine($"Manufacturer: {Manufacturer}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Release Year: {ReleaseYear}");
        Console.WriteLine($"Bit: {Bit}");
    }
}
