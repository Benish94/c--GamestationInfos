public class XboxSeriesX : IConsole
{
    public string Name { get; } = "Xbox Series X";
    public int ReleaseYear { get; } = 2020;
    public int Bit { get; } = 64;
    public string Manufacturer { get; } = "Microsoft";

    public void ShowInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Erscheinungsjahr: " + ReleaseYear);
        Console.WriteLine("Bit: " + Bit);
        Console.WriteLine("Hersteller: " + Manufacturer);
    }
}
