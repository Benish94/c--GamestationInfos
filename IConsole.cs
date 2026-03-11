public interface IConsole
{
    string Name { get; }
    int ReleaseYear { get; }
    int Bit { get; }
    string Manufacturer { get; }

    void ShowInfo();
}