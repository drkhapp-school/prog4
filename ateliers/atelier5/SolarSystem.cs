using System;
using System.Collections.Generic;

namespace atelier5
{
  public class SolarSystem : CelestialObject
  {
    private List<CelestialBodyWithCore> _bodies;

    public SolarSystem() 
    {
      _bodies = new List<CelestialBodyWithCore>();
    }
    
    public SolarSystem(string name) : base(name)
    {
      _bodies = new List<CelestialBodyWithCore>();
    }

    public CelestialBodyWithCore this[int i] => _bodies[i];

    public void Add(params CelestialBodyWithCore[] bodies)
    {
      foreach (var body in bodies)
        if (body.GetType() == typeof(Star)) AddStar(body);
        else AddBody(body);
    }

    public IList<CelestialBodyWithCore> Bodies => _bodies.AsReadOnly();

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