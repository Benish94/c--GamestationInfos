public class SNES : Konsole
{
    public override string Name { get; } = "Super Nintendo Entertainment System";
    public override int ReleaseYear { get; } = 1990;
    public override int Bit { get; } = 16;
    public override string Manufacturer { get; } = "Nintendo";
    public override int Stock { get; set; } = 60;
}
