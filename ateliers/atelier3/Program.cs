using System;

namespace atelier3
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      Planet earth = new Planet("earth", 6371, 1);
      Planet mars = new Planet("mars", 3389.5, 0.107);
      Planet venus = new Planet("venus", 6051.8, 0.815);
      Planet saturn = new Planet("venus", 58232, 95.16);
      Console.WriteLine("Earth statistics");
      Console.WriteLine("name: " + earth.Name);
      Console.WriteLine("radius: " + earth.Radius);
      Console.WriteLine("mass: " + earth.Mass);
      Console.WriteLine("area: " + earth.Area);
      Console.WriteLine("volume: " + earth.Volume);
      Console.WriteLine("density: " + earth.Density);
    }
  }
}