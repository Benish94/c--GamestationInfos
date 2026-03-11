public abstract class Konsole : IConsole, IStockManager
{
    public abstract string Name { get; }
    public abstract int ReleaseYear { get; }
    public abstract int Bit { get; }
    public abstract string Manufacturer { get; }
    public abstract int Stock { get; set; }

    public void ShowInfo()
    {
        System.Console.WriteLine("Name: " + Name);
        System.Console.WriteLine("Erscheinungsjahr: " + ReleaseYear);
        System.Console.WriteLine("Bit: " + Bit);
        System.Console.WriteLine("Hersteller: " + Manufacturer);
    }

    public void ShowStock()
    {
        System.Console.WriteLine("Lagerbestand: " + Stock);
    }
}
