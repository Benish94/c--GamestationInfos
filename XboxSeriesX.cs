public class XboxSeriesX : iConsole
{
    public string Manufacturer { get; set; } = "Microsoft";
    public string Name { get; set; } = "Xbox Series X";
    public int ReleaseYear { get; set; } = 2020;

    public void ShowInfo()
    {
        Console.WriteLine($"Manufacturer: {Manufacturer}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Release Year: {ReleaseYear}");
    }
}
