public class SegaMegaDrive2 : IConsole
{
    public string Name { get; } = "Sega Mega Drive";
    public int ReleaseYear { get; } = 1988;
    public int Bit { get; } = 16;
    public string Manufacturer { get; } = "Sega";

    public void ShowInfo()
    {
        Console.WriteLine("{0,-15} {1}", "Name: " + Name);
        Console.WriteLine("{0,-15} {1}", "Erscheinungsjahr: " + ReleaseYear);
        Console.WriteLine("{0,-15} {1}", "Bit: " + Bit);
        Console.WriteLine("{0,-15} {1}", "Hersteller: " + Manufacturer);
    }
}
