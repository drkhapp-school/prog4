using System;

namespace atelier5
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      // Galaxy
      var milkyWay = new Galaxy("Milky Way", "Quirky");

      // Solar System
      var solarSystem = new SolarSystem(milkyWay, "Solar System");

      // Star
      var sun = new Star(solarSystem, "Sun", 696340, 333000);

      // Planet
      var mercury = new Planet(solarSystem, "Mercury", 2439.7, 0.055);
      var venus = new Planet(solarSystem, "Venus", 6051.8, 0.815);
      var earth = new Planet(solarSystem, "Earth", 6371, 1);
      var mars = new Planet(solarSystem, "Mars", 3389.5, 0.107);
      var jupiter = new Planet(solarSystem, "Jupiter", 69911, 317.8);
      var saturn = new Planet(solarSystem, "Saturn", 58232, 95.16);
      var neptune = new Planet(solarSystem, "Neptune", 24622, 17.15);
      var uranus = new Planet(solarSystem, "Uranus", 25362, 14.54);
      var pluto = new Planet(solarSystem, "Pluto", 1188.3, 0.00218);

      // Moon
      var moon = new Moon("Moon", 1737.4, 0.0123, earth);
      var europa = new Moon("Europa", 1560.8, 0.008, jupiter);
      var io = new Moon("Io", 1821.6, 0.015, jupiter);
      var ganymede = new Moon("Ganymede", 2634.1, 0.413, jupiter);
      var titan = new Moon("Titan", 2574.7, 0.0225, saturn);
      var phobos = new Moon("Phobos", 11.2667, 1.784, mars);

      // Modifications
      sun.Corona = 4;
      earth.CoreSize = 20;

      Console.WriteLine(milkyWay.PrintAll());

      // Console.WriteLine("Milky Way:");
      // foreach (var system in milkyWay.Systems)
      // {
      //   Console.WriteLine($"- {system}:");
      //   foreach (var body in system.Bodies)
      //   {
      //     Console.WriteLine($"  - {body}:");
      //     if (body.GetType() != typeof(Planet)) continue;
      //     foreach (var children in ((Planet) body).Moons) Console.WriteLine($"    - {children}");
      //   }
      // }
    }
  }
}