public class SNES : IConsole
{
    public string Name { get; } = "Super Nintendo";
    public int ReleaseYear { get; } = 1234;
    public int Bit { get; } = 3;
    public string Manufacturer { get; } = "Nintendo";

    public int Stock { get; set; } = 100;

    public void ShowStock()
    {
        Console.WriteLine("Stock: " + Stock);
    }
    public void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Release Year: {ReleaseYear}");
        Console.WriteLine($"Bit: {Bit}");
        Console.WriteLine($"Manufacturer: {Manufacturer}");
    }
}
