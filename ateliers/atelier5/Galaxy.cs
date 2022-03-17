using System.Collections.Generic;
using System.Linq;

namespace atelier5
{
  public class Galaxy : CelestialObject
  {
    private List<Orbitable> _children;

    /// <summary>
    ///   Represents the solar systems that are found in the galaxy.
    /// </summary>
    private List<SolarSystem> _systems;

    /// <summary>
    ///   Represents the type of the galaxy.
    /// </summary>
    private string _type;

    /// <summary>
    ///   Initializes a new galaxy.
    /// </summary>
    /// <param name="name">The name of the galaxy.</param>
    /// <param name="type">The type of the galaxy.</param>
    public Galaxy(string name, string type) : base(name)
    {
      _type = type;
      _systems = new List<SolarSystem>();
      _children = new List<Orbitable>();
    }

    /// <summary>
    ///   Initializes a new galaxy with an unknown type.
    /// </summary>
    /// <param name="name">The name of the galaxy.</param>
    public Galaxy(string name) : base(name)
    {
      _type = "Unknown";
      _systems = new List<SolarSystem>();
      _children = new List<Orbitable>();
    }

    /// <summary>
    ///   Initializes a new galaxy with an unknown name and type.
    /// </summary>
    public Galaxy()
    {
      _type = "Unknown";
      _systems = new List<SolarSystem>();
      _children = new List<Orbitable>();
    }

    /// <summary>
    ///   Represents the type of the galaxy.
    /// </summary>
    public string Type
    {
      get => _type;
      set => _type = value;
    }

    /// <summary>
    ///   Returns a solar system found in the current galaxy.
    /// </summary>
    /// <param name="i">The index of the solar system.</param>
    public SolarSystem this[int i] => _systems[i];

    public IList<SolarSystem> Systems => _systems.AsReadOnly();

    /// <summary>
    ///   Adds a range of solar systems to the galaxy.
    /// </summary>
    /// <param name="solarSystems">The solar systems to add.</param>
    /// <remarks>A galaxy cannot contain multiple of the same solar system.</remarks>
    public void Add(params SolarSystem[] solarSystems)
    {
      foreach (var solarSystem in solarSystems)
      {
        if (_systems.Contains(solarSystem)) continue;
        _systems.Add(solarSystem);
      }
    }

    /// <summary>
    ///   Removes a solar system from the galaxy.
    /// </summary>
    /// <param name="solarSystem">The solar system to remove.</param>
    /// <returns>True if the solar system was removed; otherwise false.</returns>
    public bool Remove(SolarSystem solarSystem)
    {
      return !_systems.Contains(solarSystem) && _systems.Remove(solarSystem);
    }

    public string PrintAll()
    {
      return _children.Aggregate("", (current, body) => current + (body + "\n"));
    }

    public override void AddCelestialObject(Orbitable child)
    {
      _children.Add(child);
    }
  }
}