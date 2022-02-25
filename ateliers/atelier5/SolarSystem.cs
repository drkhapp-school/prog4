using System;
using System.Collections.Generic;

namespace atelier5
{
  public class SolarSystem
  {
    private string _name;
    private List<CelestialBodyWithCore> _bodies;

    public SolarSystem(string name)
    {
      _name = name;
      _bodies = new List<CelestialBodyWithCore>();
    }

    public string Name
    {
      get => _name;
      set => _name = value;
    }

    public void Add(Star obj)
    {
      if (_bodies.Contains(obj)) return;
      if (_bodies.FindAll(core => core.GetType() == typeof(Star)).Count >= 3)
      {
        throw new Exception("A solar system cannot have more than 3 stars.");
      }

      _bodies.Add(obj);
    }

    public void Add(Planet obj)
    {
      if (_bodies.Contains(obj)) return;

      _bodies.Add(obj);
    }

    public void Remove(CelestialBodyWithCore obj)
    {
      _bodies.Remove(obj);
    }

    public CelestialBodyWithCore this[int i] => _bodies[i];
  }
}