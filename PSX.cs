public class PSX : Konsole
{
    public override string Name { get; } = "PlayStation 1";
    public override int ReleaseYear { get; } = 1994;
    public override int Bit { get; } = 32;
    public override string Manufacturer { get; } = "Sony";
    public override int Stock { get; set; } = 75;
}
