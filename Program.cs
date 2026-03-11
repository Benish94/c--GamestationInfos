Console.WriteLine("---Konsolen Infos---\n");

foreach (KonsolenName name in Enum.GetValues<KonsolenName>())
{
    Konsole console = new(name);
    console.ShowInfo();
    console.ShowStock();
    Console.WriteLine("\n");
}

public enum KonsolenName
{
    Gameboy,
    Nes,
    SNES,
    NintendoDS,
    PlayStation4,
    PSX,
    XboxSeriesX,
    SegaMegaDrive,
    SegaMegaDrive2
}
