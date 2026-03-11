public class PlayStation4 : Konsole
{
    public override string Name { get; } = "PlayStation 4";
    public override int ReleaseYear { get; } = 2013;
    public override int Bit { get; } = 64;
    public override string Manufacturer { get; } = "Sony";
    public override int Stock { get; set; } = 91;
}
