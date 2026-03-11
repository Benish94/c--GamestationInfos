using System;
 
public class Nes : IConsole
{
    public string Name { get; } = "Nintendo Entertainment System";
    public string Manufacturer { get; } = "Nintendo";
    public int ReleaseYear { get; } = 1985;
    public int Bit { get; } = 8;
    public int Stock { get; set; } = 88;
 
 
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