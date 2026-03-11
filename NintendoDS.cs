public class NintendoDS : IConsole
{
    public string Name { get; } = "Nintendo DS";
    public int ReleaseYear { get; } = 2004;
    public int Bit { get; } = 32;
    public string Manufacturer { get; } = "Nintendo";

    public void ShowInfo()
    {
        Console.WriteLine("{0,-15} {1}", "Name: " + Name);
        Console.WriteLine("{0,-15} {1}", "Erscheinungsjahr: " + ReleaseYear);
        Console.WriteLine("{0,-15} {1}", "Bit: " + Bit);
        Console.WriteLine("{0,-15} {1}", "Hersteller: " + Manufacturer);
    }

}
