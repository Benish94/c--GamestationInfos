using RetroKonsole;

List<IConsole> consoles = new()
{
    new Gameboy(),
    new Nes(),
    new SNES(),
    new NintendoDS(),
    new PSX(),
    new PlayStation4(),
    new SegaMegaDrive2(),
    new XboxSeriesX(),
};

foreach (IConsole console in consoles)
{
    console.ShowInfo();
}

Gameboy gameboy = new Gameboy();
gameboy.ShowStock();