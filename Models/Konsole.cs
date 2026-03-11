namespace GamestationInfo;

public abstract class Konsole : IConsole
{
    public string Name { get; }
    public int ReleaseYear { get; }
    public int Bit { get; }
    public string Manufacturer { get; }
    public int Stock { get; set; }

    protected Konsole(string name, int releaseYear, int bit, string manufacturer, int stock)
    {
        Name = name;
        ReleaseYear = releaseYear;
        Bit = bit;
        Manufacturer = manufacturer;
        Stock = stock;
    }

    public virtual void ShowInfo()
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