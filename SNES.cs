public class SNES : IConsole
{
    public string Name { get; set; }
    public int ReleaseYear { get; set; }
    public int Bit { get; set; }
    public string Manufacturer { get; set; }

    public SNES(string name, int releaseYear, int bit, string manufacturer)
    {
        Name = name;
        ReleaseYear = releaseYear;
        Bit = bit;
        Manufacturer = manufacturer;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Release Year: {ReleaseYear}");
        Console.WriteLine($"Bit: {Bit}");
        Console.WriteLine($"Manufacturer: {Manufacturer}");
    }
}
