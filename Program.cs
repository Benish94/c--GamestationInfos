using System.Reflection;
using System.Text.Json;
using GamestationInfo;

List<Konsole> consoles = Assembly.GetExecutingAssembly()
    .GetTypes()
    .Where(t => typeof(Konsole).IsAssignableFrom(t) && !t.IsAbstract)
    .Select(t => (Konsole)Activator.CreateInstance(t)!)
    .ToList();

foreach (Konsole console in consoles)
{
    console.ShowInfo();
    console.ShowStock();
    Console.WriteLine();
}

var options = new JsonSerializerOptions
{
    WriteIndented = true
};

string json = JsonSerializer.Serialize(consoles, options);
File.WriteAllText("konsolen.json", json);

Console.WriteLine("JSON Datei wurde erstellt.");