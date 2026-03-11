using System.Text.Json;
using Gamestation_Info;


var json = File.ReadAllText("consoles.json");
var consoles = JsonSerializer.Deserialize<List<Konsole>>(json);

if (consoles == null)
{
    Environment.Exit(1);
}

foreach (Konsole console in consoles)
{
    console.ShowInfo();
    console.ShowStock();
}
