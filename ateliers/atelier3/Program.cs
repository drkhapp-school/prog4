using System;

namespace atelier3
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      var mercury = new Planet("Mercury", 2439.7, 0.055);
      var venus = new Planet("Venus", 6051.8, 0.815);
      var earth = new Planet("Earth", 6371, 1);
      var mars = new Planet("Mars", 3389.5, 0.107);
      var jupiter = new Planet("Jupiter", 69911, 317.8);
      var saturn = new Planet("Saturn", 58232, 95.16);
      var neptune = new Planet("Neptune", 24622, 17.15);
      var uranus = new Planet("Uranus", 25362, 14.54);
      var pluto = new Planet("Pluto", 1188.3, 0.00218);

      Console.WriteLine(mercury.ToString());
      Console.WriteLine(venus.ToString());
      Console.WriteLine(earth.ToString());
      Console.WriteLine(mars.ToString());
      Console.WriteLine(jupiter.ToString());
      Console.WriteLine(saturn.ToString());
      Console.WriteLine(neptune.ToString());
      Console.WriteLine(uranus.ToString());
      Console.WriteLine(pluto.ToString());

      Console.WriteLine("-----");

      Console.WriteLine("Creating a custom planet.");
      var cool = new Planet("cool", 420, 69);
      Console.WriteLine(cool.ToString());

      Console.WriteLine("Doubling radius.");
      cool.Radius *= 2;
      Console.WriteLine(cool.ToString());

      Console.WriteLine("Comparing it to earth.");
      switch (cool.CompareTo(earth))
      {
        case -1:
          Console.WriteLine("Earth's bigger.");
          break;
        case 0:
          Console.WriteLine("They're equal.");
          break;
        case 1:
          Console.WriteLine("Cool's bigger.");
          break;
      }

      Console.WriteLine("Cool is " + (cool.Equals(earth) ? "equal" : "not equal") + " to earth.");
    }
  }
}