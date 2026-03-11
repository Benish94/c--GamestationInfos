using System.Text.Json;

string json = File.ReadAllText("Dictionary.json");
Dictionary<string, Konsole>? konsolen = JsonSerializer.Deserialize<Dictionary<string, Konsole>>(json);

if (konsolen is null)
{
    Console.WriteLine("Fehler beim Laden der Konsoleninformationen.");
    return;
}

foreach (KeyValuePair<string, Konsole> eintrag in konsolen)
{
    IConsole console = eintrag.Value;
    IStockManager stockManager = eintrag.Value;

    console.ShowInfo();
    stockManager.ShowStock();
    Console.WriteLine();
}
