public class XboxSeriesX : IConsole
{
    public string Name { get; } = "Xbox Series X";
    public int ReleaseYear { get; } = 2020;
    public int Bit { get; } = 64;
    public string Manufacturer { get; } = "Microsoft";

    public void ShowInfo()
    {
        Console.WriteLine("{0,-15} {1}", "Name: " + Name);
        Console.WriteLine("{0,-15} {1}", "Erscheinungsjahr: " + ReleaseYear);
        Console.WriteLine("{0,-15} {1}", "Bit: " + Bit);
        Console.WriteLine("{0,-15} {1}", "Hersteller: " + Manufacturer);
    }
}
