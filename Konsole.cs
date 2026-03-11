namespace Gamestation_Info
{
    public class Konsole : IConsole
    {
        public string Name { get; private set; } = "";
        public string Manufacturer { get; private set; } = "";
        public int ReleaseYear { get; private set; }
        public int Bit { get; private set; }

        public int Stock { get; set; }

        public Konsole(string name, string manufacturer, int releaseYear, int bit, int stock)
        {
            Name = name;
            Manufacturer = manufacturer;
            ReleaseYear = releaseYear;
            Bit = bit;
            Stock = stock;
        }

        public void ShowStock()
        {
            Console.WriteLine("Stock: " + Stock);
        }

        public void ShowInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Hersteller: " + Manufacturer);
            Console.WriteLine("Erscheinungsjahr: " + ReleaseYear);
            Console.WriteLine("Bit: " + Bit);
        }
    }
}
