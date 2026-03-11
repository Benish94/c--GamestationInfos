public interface IConsole
{
    string Name { get; set; }
    int ReleaseYear { get; set; }
    int Bit { get; set; }
    string Manufacturer { get; set; }
    void ShowInfo();
    void ShowStock();
}