using System;
using System.Reflection.Metadata;



       public class PSX : IConsole
    {
    
        public string Name;
        public int ReleaseYear;
        public int Bit;
        public string Manufacturer;

        public PSX(string name, int year, int bit, string manufacturer)
        {
            Name = "PlayStation 1";
            ReleaseYear = 1994;
            Bit = 32;
            Manufacturer = "Sony";
        } 
        public void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Release Year: {ReleaseYear}");
        Console.WriteLine($"Bit: {Bit}");
        Console.WriteLine($"Manufacturer: {Manufacturer}");
    }

    }
  
    
      