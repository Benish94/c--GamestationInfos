public class Nes : Konsole
{
    public override string Name { get; } = "Nintendo Entertainment System";
    public override int ReleaseYear { get; } = 1985;
    public override int Bit { get; } = 8;
    public override string Manufacturer { get; } = "Nintendo";
    public override int Stock { get; set; } = 55;
}
