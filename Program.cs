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
    //console.ShowStock();
    //console.Stock = 50;
}

Gameboy gameboy = new Gameboy();
//gameboy.ShowStock();
((IStockManager)gameboy).ShowStock();

//ganeboy.Stock = 50;
((IStockManager)gameboy).Stock = 50;
//gameboy.ShowStock();
((IStockManager)gameboy).ShowStock();