
using System.Text.Json;
using System.IO;

var json = File.ReadAllText("consoles.json");
var consoles = JsonSerializer.Deserialize<List<Konsole>>(json);

foreach (var console in consoles)
{
    console.ShowInfo();
}


foreach (var console in consoles)
{
    ((IStockManager)console).ShowStock();
}