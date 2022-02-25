using System.Collections.Generic;

namespace atelier5.Classes
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

    public Moon this[int i] => _moons[i];

    public IList<Moon> Moons => _moons.AsReadOnly();

    public void Add(params Moon[] moons)
    {
      foreach (var moon in moons)
      {
        if (_moons.Contains(moon)) continue;
        _moons.Add(moon);
      }
    }

    public void Remove(params Moon[] moons)
    {
      foreach (var moon in moons) _moons.Remove(moon);
    }
  }
}