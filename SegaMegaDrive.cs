public class SegaMegaDrive : Konsole
{
    public override string Name { get; } = "Sega Mega Drive";
    public override int ReleaseYear { get; } = 1988;
    public override int Bit { get; } = 16;
    public override string Manufacturer { get; } = "Sega";
    public override int Stock { get; set; } = 42;
}
