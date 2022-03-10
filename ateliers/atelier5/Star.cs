namespace atelier5
{
  public class Star : CelestialBodyWithCore
  {
    private double _corona;
    private SolarSystem _parent;

    /// <summary>
    ///   Initializes a new star with unknown properties.
    /// </summary>
    public Star(SolarSystem parent)
    {
      _parent = parent;
      _parent.Parent.AddCelestialBody(this);
      Corona = 0;
    }

    /// <summary>
    ///   Initializes a new star with an unknown radius, mass, core size and corona.
    /// </summary>
    /// <param name="name">The name of the star.</param>
    public Star(SolarSystem parent, string name) : base(name)
    {
      _parent = parent;
      _parent.Parent.AddCelestialBody(this);
      _corona = 0;
    }

    /// <summary>
    ///   Initializes a new star with an unknown core size and corona.
    /// </summary>
    /// <param name="name">The name of the star.</param>
    /// <param name="radius">The radius of the star.</param>
    /// <param name="mass">The mass of the star.</param>
    public Star(SolarSystem parent, string name, double radius, double mass) : base(name, radius, mass)
    {
      _parent = parent;
      _parent.Parent.AddCelestialBody(this);
      _corona = 0;
    }

    /// <summary>
    ///   Initializes a new star.
    /// </summary>
    /// <param name="name">The name of the star.</param>
    /// <param name="radius">The radius of the star.</param>
    /// <param name="mass">The mass of the star.</param>
    /// <param name="coreSize">The core size of the star.</param>
    /// <param name="corona">The corona of the star.</param>
    public Star(SolarSystem parent, string name, double radius, double mass, double coreSize, double corona) : base(
      name, radius, mass,
      coreSize)
    {
      _parent = parent;
      _parent.Parent.AddCelestialBody(this);
      _corona = corona;
    }

    /// <summary>
    ///   Represents the corona of the sun.
    /// </summary>
    public double Corona
    {
      get => _corona;
      set => _corona = value;
    }
    
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

    public override string ToString()
    {
      return base.ToString() + $", Corona: {Corona}";
    }
  }
}