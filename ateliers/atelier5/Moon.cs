namespace atelier5
{
  public class Moon : CelestialBody
  {
    private Planet _parent;
    
    /// <summary>
    /// Initializes a new moon.
    /// </summary>
    /// <param name="name">The name of the moon.</param>
    /// <param name="radius">The radius of the moon.</param>
    /// <param name="mass">The mass of the moon.</param>
    /// <param name="parent">The planet that the moon orbits.</param>
    public Moon(string name, double radius, double mass, Planet parent) : base(name, radius, mass)
    {
      _parent = parent;
      _parent.Parent.Parent.AddCelestialBody(this);
    }

    /// <summary>
    /// Initializes a new moon with an unknown radius and mass.
    /// </summary>
    /// <param name="name">The name of the moon.</param>
    /// <param name="parent">The planet that the moon orbits.</param>
    public Moon(string name, Planet parent) : base(name)
    {
      _parent = parent;
      _parent.Parent.Parent.AddCelestialBody(this);
    }

    /// <summary>
    /// Initializes a new moon with an unknown name, radius and mass.
    /// </summary>
    public Moon(Planet parent)
    {
      _parent = parent;
      _parent.Parent.Parent.AddCelestialBody(this);
    }

    public Planet Parent
    {
      get => _parent;
      set
      {
        _parent.Remove(this);
        _parent = value;
        value.Add(this);
      }
    }
  }
}