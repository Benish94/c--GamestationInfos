public interface IConsole
{
    string Name { get; }
    int ReleaseYear { get; }
    int Bit { get; }
    string Manufacturer { get; }
    int Stock { get; set; }

    void ShowInfo();
    void ShowStock();
}