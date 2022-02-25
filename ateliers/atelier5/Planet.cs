using System.Collections.Generic;

namespace atelier5
{
  public class Planet : CelestialBodyWithCore
  {
    private List<Moon> _moons;

    public Planet()
    {
      _moons = new List<Moon>();
    }

    public Planet(string name) : base(name)
    {
      _moons = new List<Moon>();
    }

    public Planet(string name, double radius, double mass) : base(name, radius, mass)
    {
      _moons = new List<Moon>();
    }

    public Planet(string name, double radius, double mass, int core) : base(name, radius, mass, core)
    {
      _moons = new List<Moon>();
    }
  }
}