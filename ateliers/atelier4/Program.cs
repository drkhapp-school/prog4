using System;

namespace atelier4
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      var neptune = new Planet("Neptune", 699, 31.8);
      var jupiter = new Planet("Jupiter", 69911, 317.8);

      var europa = new Moon("Europa", 1560.8, 0.008);
      var io = new Moon("Io", 1821.6, 0.015);
      var ganymede = new Moon("Ganymede", 2634.1, 0.413);
      var testPlanet = new Moon("Test", 5563, 1);

      jupiter.Add(io, europa, ganymede, testPlanet, new Moon("uwu"));

      jupiter += testPlanet;

      var badJupiter = jupiter - io;
      foreach (var moon in badJupiter.Moons) Console.WriteLine(moon);
      
      Console.WriteLine("-----");

      jupiter.Moons.Sort();
      foreach (var moon in jupiter.Moons) Console.WriteLine(moon);

      Console.WriteLine(neptune < jupiter);
      Console.WriteLine(neptune <= jupiter);
      Console.WriteLine(neptune == jupiter);
      Console.WriteLine(neptune != jupiter);
      Console.WriteLine(neptune >= jupiter);
      Console.WriteLine(neptune > jupiter);
    }
  }
}