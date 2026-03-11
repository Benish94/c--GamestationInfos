public class Konsole : IConsole, IStockManager
{
    public string Name { get; private set; }
    public int ReleaseYear { get; private set; }
    public int Bit { get; private set; }
    public string Manufacturer { get; private set; }
    public int Stock { get; set; }

    public Konsole(KonsolenName name)
    {
        switch (name)
        {
            case KonsolenName.Gameboy:
                Name = "Nintendo Game Boy"; ReleaseYear = 1989; Bit = 8; Manufacturer = "Nintendo"; Stock = 88; break;
            case KonsolenName.Nes:
                Name = "Nintendo Entertainment System"; ReleaseYear = 1985; Bit = 8; Manufacturer = "Nintendo"; Stock = 55; break;
            case KonsolenName.SNES:
                Name = "Super Nintendo Entertainment System"; ReleaseYear = 1990; Bit = 16; Manufacturer = "Nintendo"; Stock = 60; break;
            case KonsolenName.NintendoDS:
                Name = "Nintendo DS"; ReleaseYear = 2004; Bit = 32; Manufacturer = "Nintendo"; Stock = 27; break;
            case KonsolenName.PlayStation4:
                Name = "PlayStation 4"; ReleaseYear = 2013; Bit = 64; Manufacturer = "Sony"; Stock = 91; break;
            case KonsolenName.PSX:
                Name = "PlayStation 1"; ReleaseYear = 1994; Bit = 32; Manufacturer = "Sony"; Stock = 75; break;
            case KonsolenName.XboxSeriesX:
                Name = "Xbox Series X"; ReleaseYear = 2020; Bit = 64; Manufacturer = "Microsoft"; Stock = 33; break;
            case KonsolenName.SegaMegaDrive:
                Name = "Sega Mega Drive"; ReleaseYear = 1988; Bit = 16; Manufacturer = "Sega"; Stock = 42; break;
            case KonsolenName.SegaMegaDrive2:
                Name = "Sega Mega Drive 2"; ReleaseYear = 1988; Bit = 16; Manufacturer = "Sega"; Stock = 18; break;
            default:
                throw new ArgumentException("Unbekannte Konsole: " + name);
        }
    }

    public void ShowInfo()
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
