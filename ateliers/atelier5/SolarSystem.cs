using System;
using System.Collections.Generic;

namespace atelier5
{
  public class SolarSystem : CelestialObject
  {
    private List<CelestialBodyWithCore> _bodies;
    private Galaxy _parent;

    public SolarSystem(Galaxy parent)
    {
      _parent = parent;
      _parent.AddCelestialBody(this);
      _bodies = new List<CelestialBodyWithCore>();
    }

    public SolarSystem(Galaxy parent, string name) : base(name)
    {
      _parent = parent;
      _parent.AddCelestialBody(this);
      _bodies = new List<CelestialBodyWithCore>();
    }

    public CelestialBodyWithCore this[int i] => _bodies[i];

    public IList<CelestialBodyWithCore> Bodies => _bodies.AsReadOnly();

    public Galaxy Parent
    {
      get => _parent;
      set
      {
        _parent.Remove(this);
        _parent = value;
        _parent.Add(this);
      }
    }

    public void Add(params CelestialBodyWithCore[] bodies)
    {
      foreach (var body in bodies)
        if (body.GetType() == typeof(Star)) AddStar(body);
        else AddBody(body);
    }

    private void AddStar(CelestialBodyWithCore obj)
    {
      if (_bodies.Contains(obj)) return;
      if (_bodies.FindAll(core => core.GetType() == typeof(Star)).Count >= 3)
        throw new Exception("A solar system cannot have more than 3 stars.");

      _bodies.Add(obj);
    }

    private void AddBody(CelestialBodyWithCore obj)
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