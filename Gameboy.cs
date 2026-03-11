public class Gameboy : Konsole
{
    public override string Name { get; } = "Nintendo Game Boy";
    public override int ReleaseYear { get; } = 1989;
    public override int Bit { get; } = 8;
    public override string Manufacturer { get; } = "Nintendo";
    public override int Stock { get; set; } = 88;
}
