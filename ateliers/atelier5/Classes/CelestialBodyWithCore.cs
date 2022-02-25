using System;

namespace atelier5.Classes
{
  public abstract class CelestialBodyWithCore : CelestialBody
  {
    private double _coreSize;

    protected CelestialBodyWithCore()
    {
      CoreSize = 0;
    }

    protected CelestialBodyWithCore(string name) : base(name)
    {
      CoreSize = 0;
    }

    protected CelestialBodyWithCore(string name, double radius, double mass) : base(name, radius, mass)
    {
      CoreSize = 0;
    }

    protected CelestialBodyWithCore(string name, double radius, double mass, double coreSize) : base(name, radius, mass)
    {
      CoreSize = coreSize;
    }

    public double Core => CalculateCore(Radius, _coreSize);

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

    private static double CalculateCore(double radius, double coreSize)
    {
      return radius * coreSize / 100;
    }
  }
}