using RetroKonsole;

List<IConsole> consoles = new List<IConsole>()
{
    // new Gameboy(),
    // new Nes("Nintendo Entertainment System", "Nintendo", 1983, 8),
    // new SNES("Super Nintendo Entertainment System", 1990, 16, "Nintendo"),
    new NintendoDS(),
//     new PSX("PlayStation 1", 1994, 32, "Sony"),
//     new PlayStation4("PlayStation 4", 2013, 64, "Sony"),
//     new SegaMegaDrive2(),
//     new XboxSeriesX(),
//
};

foreach (IConsole console in consoles)
{
    console.ShowInfo();
}

List<IStockManager> stockManagers = new List<IStockManager>()
{
    new NintendoDS(),
};

foreach (IStockManager stockManager in stockManagers)
{
    stockManager.ShowStock();
    Console.WriteLine("Bestand: " + stockManager.Stock);
}
