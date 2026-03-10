using System;

class Nes : iConsole
{
    public string Name { get; set; }
    public string Manufacturer { get; set; }
    public int ReleaseYear { get; set; }
    public int Bit { get; set; }

    public Nes(string name, string manufacturer, int releaseYear, int bit)
    {
        Name = name;
        ReleaseYear = releaseYear;
        Bit = bit;
        Manufacturer = manufacturer;
    }

    public void ShowInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Hersteller: " + Manufacturer);
        Console.WriteLine("Erscheinungsjahr: " + ReleaseYear);
        Console.WriteLine("Bit: " + Bit);
    }
}
