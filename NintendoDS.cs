public class NintendoDS : IConsole
{
    public string Name { get; } = "Nintendo DS";
    public int ReleaseYear { get; } = 2004;
    public int Bit { get; } = 32;
    public string Manufacturer { get; } = "Nintendo";

    public void ShowInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Erscheinungsjahr: " + ReleaseYear);
        Console.WriteLine("Bit: " + Bit);
        Console.WriteLine("Hersteller: " + Manufacturer);
    }

}
