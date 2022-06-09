using Galactica_osca1678;

Data Data = new();

if (Data.Sun.PlanetList == null) return;

Console.WriteLine("Planets:");

foreach (Planet p in Data.Sun.PlanetList)
{
    Console.WriteLine($"{p.Name} Type {p.Type}");
    if (p.MoonList != null)
    {
        Console.WriteLine("Moons:");
        foreach (Moon m in p.MoonList)
        {
            Console.WriteLine($"{m.Name}");
        }
    }
}
