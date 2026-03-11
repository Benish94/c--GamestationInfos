using System.Text.Json;

var json = File.ReadAllText("consoles.json");
List<Konsole> consoles = JsonSerializer.Deserialize<List<Konsole>>(json)!;

Console.WriteLine("---Konsolen Infos---\n");

foreach (Konsole console in consoles)
{
    console.ShowInfo();
    console.ShowStock();
    Console.WriteLine();
}
