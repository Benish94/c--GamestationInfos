public class SegaMegaDrive2 : IConsole
{

    public string Name { get; } = "Sega Mega Drive";
    public string Manufacturer { get; } = "Sega";
    public int ReleaseYear { get; } = 1988;
    public int Bit { get; } = 16;

    public int Stock { get; set; } = 100;

    public void ShowStock()
    {
        Console.WriteLine("Stock: " + Stock);
    }

    public void ShowInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Hersteller: " + Manufacturer);
        Console.WriteLine("Erscheinungsjahr: " + ReleaseYear);
        Console.WriteLine("Bit: " + Bit);
    }
}
