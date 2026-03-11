public class SNES : IConsole
{
    public string Name { get; } = "Super Nintendo Entertainment System";
    public int ReleaseYear { get; } = 1990;
    public int Bit { get; } = 16;
    public string Manufacturer { get; } = "Nintendo";

    public void ShowInfo()
    {
        Console.WriteLine("{0,-15} {1}", "Name: " + Name);
        Console.WriteLine("{0,-15} {1}", "Erscheinungsjahr: " + ReleaseYear);
        Console.WriteLine("{0,-15} {1}", "Bit: " + Bit);
        Console.WriteLine("{0,-15} {1}", "Hersteller: " + Manufacturer);
    }
}
