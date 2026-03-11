namespace Gamestation_Info
{
    public class Konsole : IConsole
    {
        public string Name { get; set; } = "";
        public string Manufacturer { get; set; } = "";
        public int ReleaseYear { get; set; }
        public int Bit { get; set; }

        public int Stock { get; set; }


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
