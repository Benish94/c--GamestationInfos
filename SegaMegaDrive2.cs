public class SegaMegaDrive2 : IConsoleProduct
{
    public string Name { get; } = "Sega Mega Drive";
    public int ReleaseYear { get; } = 1988;
    public int Bit { get; } = 16;
    public string Manufacturer { get; } = "Sega";
    public int Stock { get; set; } = 18;

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
