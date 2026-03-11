List<IConsoleProduct> consoles = [];
consoles.Add(new Gameboy());
consoles.Add(new Nes());
consoles.Add(new SNES());
consoles.Add(new NintendoDS());
consoles.Add(new PlayStation4());
consoles.Add(new PSX());
consoles.Add(new XboxSeriesX());
consoles.Add(new SegaMegaDrive());
consoles.Add(new SegaMegaDrive2());

Console.WriteLine("---Konsolen Infos---\n");

foreach(IConsoleProduct console in consoles)
{
    console.ShowInfo();
    console.ShowStock();
    Console.WriteLine("\n");
}