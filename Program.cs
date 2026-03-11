List<IConsole> consolen = [];
consolen.Add(new Gameboy());
consolen.Add(new Nes());
consolen.Add(new SNES());
consolen.Add(new NintendoDS());
consolen.Add(new PlayStation4());
consolen.Add(new PSX());
consolen.Add(new XboxSeriesX());
consolen.Add(new SegaMegaDrive());
consolen.Add(new SegaMegaDrive2());

Console.WriteLine("---Konsolen Infos---\n");

foreach(IConsole console in consolen)
{
    console.ShowInfo();
    Console.WriteLine("\n");
}