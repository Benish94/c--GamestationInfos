public class SegaMegaDrive2 : IConsole
{
    public string Name { get; set; } = "Sega Mega Drive";
    public int ReleaseYear { get; set; } = 1988;
    public int Bit { get; set; } = 16;
    public string Manufacturer { get; set; } = "Sega";

    private int stock = 100;

    public void ShowInfo()
    {
        Console.WriteLine("");
        Console.WriteLine("Informationen zur Konsole:");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("");
        Console.WriteLine("{0,-15} {1}", "Name:", Name);
        Console.WriteLine("{0,-15} {1}", "Release Year:", ReleaseYear);
        Console.WriteLine("{0,-15} {1}", "Bit:", Bit);
        Console.WriteLine("{0,-15} {1}", "Manufacturer:", Manufacturer);
        Console.WriteLine("");
    }

    public void ShowStock()
    {
        Console.WriteLine("Aktueller Lagerbestand: {0} Stück", stock);
    }
}