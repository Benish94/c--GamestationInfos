public class NintendoDS : Konsole
{
    public override string Name { get; } = "Nintendo DS";
    public override int ReleaseYear { get; } = 2004;
    public override int Bit { get; } = 32;
    public override string Manufacturer { get; } = "Nintendo";
    public override int Stock { get; set; } = 27;
}
