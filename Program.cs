using Gamestation_Info;

List<Konsole> consoles = new()
{
    new Konsole("Nintendo Entertainment System", "Nintendo", 1983, 8, 100),
    new Konsole("Xbox Series X", "Microsoft", 2020, 64, 100),
    new Konsole("Sega Mega Drive", "Sega", 1988, 16, 100),
    new Konsole("Super Nintendo", "Nintendo", 1234, 3, 100),
    new Konsole("PlayStation 4", "Sony", 2070, 42, 100),
    new Konsole("PlayStation 1", "Sony", 1994, 32, 100),
    new Konsole("NintendoDS", "Nintendo", 1234, 7, 100),
    new Konsole("Gameboy", "Nintendo", 1989, 8, 100),
};

foreach (IConsole console in consoles)
{
    console.ShowInfo();
    console.ShowStock();
}
