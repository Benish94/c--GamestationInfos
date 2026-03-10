using System;

class PlayStation4 : iConsole
{
    public string Name { get; set; }
    public int ReleaseYear { get; set; }
    public int Bit { get; set; }
    public string Manufacturer { get; set; }

    public PlayStation4(string name, int releaseYear, int bit, string manufacturer)
    {
        Name = name;
        ReleaseYear = releaseYear;
        Bit = bit;
        Manufacturer = manufacturer;
    }

    public void ShowInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Erscheinungsjahr: " + ReleaseYear);
        Console.WriteLine("Bit: " + Bit);
        Console.WriteLine("Hersteller: " + Manufacturer);
    }
}
