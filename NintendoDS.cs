public class NintendoDS : IConsole
{
    public string Name { get; } = "Nintendo DS";
    public int ReleaseYear { get; } = 2004;
    public int Bit { get; } = 32;
    public string Manufacturer { get; } = "Nintendo";
    public int Stock { get; set; } = 27;

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
