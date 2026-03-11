public class NintendoDS : IConsole
{
    public string Name { get; } = "NintendoDs";
    public int ReleaseYear { get; } = 123124;
    public int Bit { get; } = 13;
    public string Manufacturer { get; } = "Nintendo";

    public int Stock { get; set; } = 100;

    public void ShowStock()
    {
        Console.WriteLine("Stock: " + Stock);
    }
    public void ShowInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Erscheinungsjahr: " + ReleaseYear);
        Console.WriteLine("Bit: " + Bit);
        Console.WriteLine("Hersteller: " + Manufacturer);
    }
}
