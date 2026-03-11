
using Gamestation_Info;

public interface IConsole : IStockManager
{
    public string Name { get; }
    public string Manufacturer { get; }
    public int ReleaseYear { get; }
    public int Bit { get; }

    void ShowInfo();

}
