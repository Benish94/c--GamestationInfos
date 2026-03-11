using System.Reflection;
using GamestationInfo;

List<IConsole> consoles = Assembly.GetExecutingAssembly()
    .GetTypes()
    .Where(t => typeof(Konsole).IsAssignableFrom(t) && !t.IsAbstract)
    .Select(t => (IConsole)Activator.CreateInstance(t)!)
    .ToList();

foreach (IConsole console in consoles)
{
    console.ShowInfo();
    console.ShowStock();
    Console.WriteLine();
}