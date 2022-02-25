using atelier5.Classes;

namespace atelier5
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      // Galaxy
      var milkyWay = new Galaxy("Milky Way", "Quirky");

      // Solar System
      var solarSystem = new SolarSystem("Solar System");

      // Star
      var sun = new Star("Sun", 696340, 333000);

      // Planet
      var mercury = new Planet("Mercury", 2439.7, 0.055);
      var venus = new Planet("Venus", 6051.8, 0.815);
      var earth = new Planet("Earth", 6371, 1);
      var mars = new Planet("Mars", 3389.5, 0.107);
      var jupiter = new Planet("Jupiter", 69911, 317.8);
      var saturn = new Planet("Saturn", 58232, 95.16);
      var neptune = new Planet("Neptune", 24622, 17.15);
      var uranus = new Planet("Uranus", 25362, 14.54);
      var pluto = new Planet("Pluto", 1188.3, 0.00218);

      // Moon
      var moon = new Moon("Moon", 141, 0.2);
      var europa = new Moon("Europa", 1560.8, 0.008);
      var io = new Moon("Io", 1821.6, 0.015);
      var ganymede = new Moon("Ganymede", 2634.1, 0.413);
      var titan = new Moon("Titan", 2574.7, 0.0225);
      var phobos = new Moon("Phobos", 11.2667, 1.784);

      // Adding everything
      milkyWay.Add(solarSystem);
      solarSystem.Add(sun, mercury, venus, earth, mars, jupiter, saturn, neptune, uranus, pluto);
      earth.Add(moon);
      mars.Add(phobos);
      jupiter.Add(europa, io, ganymede);
      saturn.Add(titan);
    }
  }
}