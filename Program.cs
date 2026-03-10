using System;

namespace RetroConsole 
{
class Program
    {
        static void Main(string[] args)
        {
            Psx myConsole = new Psx();

            Console.WriteLine("--- Infos zur Konsole ---");
            Console.WriteLine("Modell: " + myConsole.Name);
            Console.WriteLine("Jahr: " + myConsole.ReleaseYear);
            Console.WriteLine("Technik: " + myConsole.BitCount + "-Bit");
            Console.WriteLine("Hersteller: " + myConsole.Manufacturer);
        }
    }
}