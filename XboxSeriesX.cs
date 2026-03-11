public class XboxSeriesX : IConsole
{
    public string Name { get; } = "Xbox Series X";
    public int ReleaseYear { get; } = 2020;
    public int Bit { get; } = 64;
    public string Manufacturer { get; } = "Microsoft";
    public int Stock { get; set; } = 33;

    public void ShowInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Erscheinungsjahr: " + ReleaseYear);
        Console.WriteLine("Bit: " + Bit);
        Console.WriteLine("Hersteller: " + Manufacturer);
    }

    public void ShowStock()
    {
        Console.WriteLine("Lagerbestand: " + Stock);
    }
}
