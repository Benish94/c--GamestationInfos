using System;

namespace Konsolentest
{
    class Program
    {
        static void Main(string[] args)
        {
            
            SegaMegaDrive megaDrive = new SegaMegaDrive(
                name: "Sega Mega Drive",
                releaseYear: 1988,
                bit: 16,
                manufacturer: "Sega"
            );

            
            megaDrive.PrintInfo();

            
            Console.WriteLine("\nDrücke eine Taste zum Beenden...");
            Console.ReadKey();
        }
    }
}