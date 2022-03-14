namespace atelier5
{
  public class Star : CelestialBodyWithCore
  {
    private double _corona;

    /// <summary>
    ///   Initializes a new star with unknown properties.
    /// </summary>
    public Star(CelestialObject parent) : base (parent)
    {
      _corona = 0;
    }

    /// <summary>
    ///   Initializes a new star with an unknown radius, mass, core size and corona.
    /// </summary>
    /// <param name="name">The name of the star.</param>
    public Star(CelestialObject parent, string name) : base(parent, name)
    {
      _corona = 0;
    }

    /// <summary>
    ///   Initializes a new star with an unknown core size and corona.
    /// </summary>
    /// <param name="name">The name of the star.</param>
    /// <param name="radius">The radius of the star.</param>
    /// <param name="mass">The mass of the star.</param>
    public Star(CelestialObject parent, string name, double radius, double mass) : base(parent, name, radius, mass)
    {
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
    public Star(CelestialObject parent, string name, double radius, double mass, double coreSize, double corona) : base(parent,
      name, radius, mass,
      coreSize)
    {
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

    public override string ToString()
    {
      return base.ToString() + $", Corona: {Corona}";
    }
  }
}