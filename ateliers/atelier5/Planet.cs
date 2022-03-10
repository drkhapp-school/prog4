using System.Collections.Generic;

namespace atelier5
{
  public class Planet : CelestialBodyWithCore
  {
    private List<Moon> _moons;
    private SolarSystem _parent;

    /// <summary>
    ///   Initializes a new planet with unknown properties.
    /// </summary>
    public Planet(SolarSystem parent)
    {
      _parent = parent;
      _parent.Parent.AddCelestialBody(this);
      _moons = new List<Moon>();
    }

    /// <summary>
    ///   Initializes a new planet with an unknown radius, mass and core size.
    /// </summary>
    /// <param name="name">The name of the planet.</param>
    public Planet(SolarSystem parent, string name) : base(name)
    {
      _parent = parent;
      _parent.Parent.AddCelestialBody(this);
      _moons = new List<Moon>();
    }

    /// <summary>
    ///   Initializes a new planet with an unknown core size.
    /// </summary>
    /// <param name="name">The name of the planet.</param>
    /// <param name="radius">The radius of the planet.</param>
    /// <param name="mass">The mass of the planet.</param>
    public Planet(SolarSystem parent, string name, double radius, double mass) : base(name, radius, mass)
    {
      _parent = parent;
      _parent.Parent.AddCelestialBody(this);
      _moons = new List<Moon>();
    }

    /// <summary>
    ///   Initializes a new planet.
    /// </summary>
    /// <param name="name">The name of the planet.</param>
    /// <param name="radius">The radius of the planet.</param>
    /// <param name="mass">The mass of the planet.</param>
    /// <param name="core">The size of the planet's core.</param>
    public Planet(SolarSystem parent, string name, double radius, double mass, int core) : base(name, radius, mass,
      core)
    {
      _parent = parent;
      _moons = new List<Moon>();
    }

    /// <summary>
    ///   Returns a moon found in the current planet.
    /// </summary>
    /// <param name="i">The index of the moon.</param>
    public Moon this[int i] => _moons[i];

    /// <summary>
    ///   References a read-only list of the moons that orbits the planet.
    /// </summary>
    public IList<Moon> Moons => _moons.AsReadOnly();

    public SolarSystem Parent
    {
      get => _parent;
      set
      {
        _parent.Remove(this);
        _parent = value;
        _parent.Add(this);
      }
    }

    /// <summary>
    ///   Adds a range of moons to the current planet.
    /// </summary>
    /// <param name="moons">The moons to add.</param>
    /// <remarks>A planet cannot contain multiple of the same moon.</remarks>
    public void Add(params Moon[] moons)
    {
      foreach (var moon in moons)
      {
        if (_moons.Contains(moon)) continue;
        _moons.Add(moon);
      }
    }

    /// <summary>
    ///   Removes a moon from the current planet..
    /// </summary>
    /// <param name="moon">The moon to remove.</param>
    /// <returns>True if the moon was removed; otherwise false.</returns>
    public bool Remove(Moon moon)
    {
      return _moons.Remove(moon);
    }
  }
}