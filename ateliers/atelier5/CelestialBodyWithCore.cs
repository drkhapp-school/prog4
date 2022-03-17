using System;

namespace atelier5
{
  public abstract class CelestialBodyWithCore : CelestialBody
  {
    /// <summary>
    ///   Represents the core's size relative to the celestial body.
    /// </summary>
    private double _coreSize;

    /// <inheritdoc cref="CelestialBody" />
    protected CelestialBodyWithCore(CelestialObject parent) : base(parent)
    {
      CoreSize = 0;
    }

    protected CelestialBodyWithCore(CelestialObject parent, string name) : base(parent, name)
    {
      CoreSize = 0;
    }

    /// <inheritdoc cref="CelestialBody" />
    protected CelestialBodyWithCore(CelestialObject parent, string name, double radius, double mass) : base(parent,
      name, radius, mass)
    {
      CoreSize = 0;
    }

    /// <summary>
    ///   Initializes a new celestial body.
    /// </summary>
    /// <param name="name">The name of the celestial body.</param>
    /// <param name="radius">The radius of the celestial body.</param>
    /// <param name="mass">The mass of the celestial body.</param>
    /// <param name="coreSize">The core size of the celestial body.</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when a value is lower than 0%, or is greater or equal to 100%.</exception>
    protected CelestialBodyWithCore(CelestialObject parent, string name, double radius, double mass, double coreSize) :
      base(parent, name, radius, mass)
    {
      CoreSize = coreSize;
    }

    /// <summary>
    ///   Represents the core's radius.
    /// </summary>
    public double Core => CalculateCore(Radius, _coreSize);

    /// <summary>
    ///   Represents the core's size of the celestial body.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when a value is lower than 0%, or is greater or equal to 100%.</exception>
    public double CoreSize
    {
      get => _coreSize;
      set
      {
        if (value < 0 || value >= 100)
          throw new ArgumentOutOfRangeException(nameof(value),
            "Core size must range between 0 and 100%.");

        _coreSize = value;
      }
    }

    /// <summary>
    ///   Calculates the radius of the core.
    /// </summary>
    /// <param name="radius">The radius of the celestial body.</param>
    /// <param name="coreSize">The core size's percentage relative to the celestial body.</param>
    /// <returns>The radius of the core.</returns>
    private static double CalculateCore(double radius, double coreSize)
    {
      return radius * coreSize / 100;
    }

    public override string ToString()
    {
      return base.ToString() + $", Core: {Core}";
    }
  }
}