using System;
using System.Collections.Generic;

namespace atelier5.Classes
{
  public class SolarSystem
  {
    private List<CelestialBodyWithCore> _bodies;
    private string _name;

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

    public CelestialBodyWithCore this[int i] => _bodies[i];

    public void Add(params CelestialBodyWithCore[] bodies)
    {
      foreach (var body in bodies)
        if (body.GetType() == typeof(Star)) Add((Star) body);
        else if (body.GetType() == typeof(Planet)) Add((Planet) body);
    }

    public void Add(Star obj)
    {
      if (_bodies.Contains(obj)) return;
      if (_bodies.FindAll(core => core.GetType() == typeof(Star)).Count >= 3)
        throw new Exception("A solar system cannot have more than 3 stars.");

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
  }
}