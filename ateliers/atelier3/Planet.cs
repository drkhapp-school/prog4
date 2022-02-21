using System;

namespace atelier3
{
  /// <summary>
  ///   Represents a planet.
  /// </summary>
  public class Planet
  {
    /// <summary>
    ///   Represents the equivalent of 1 Earth Mass in <c>kg</c>.
    /// </summary>
    private const double EarthMass = 5.9722e27;

    /// <summary>
    ///   Represents the planet's mass in <c>Earth Mass</c>.
    ///   The value of 1 Earth Mass is <c>5.9722e27</c>.
    /// </summary>
    private double _mass;

    /// <summary>
    ///   Represents the planet's radius in <c>km</c>.
    /// </summary>
    private double _radius;

    /// <summary>
    ///   Initializes a new planet.
    /// </summary>
    /// <param name="name"> the new planet's name.</param>
    /// <param name="radius"> the new planet's radius, in km.</param>
    /// <param name="mass"> the new planet's mass, in Earth Mass.</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <c>radius</c> or <c>mass</c> is lesser or equal to zero.</exception>
    public Planet(string name, double radius, double mass)
    {
      Name = name;
      Radius = radius;
      Mass = mass;
    }

    /// <summary>
    ///   Represents the planet's name.
    /// </summary>
    public string Name { get; set; }

    ///<summary>
    ///   Represents the planet's radius in <c>km</c>.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <c>radius</c> is lesser or equal to zero.</exception>
    public double Radius
    {
      get => _radius;
      set
      {
        if (value <= 0)
        {
          throw new ArgumentOutOfRangeException(nameof(value),"Radius must be greater than 0km.");
        }
        _radius = value;
        Area = CalculateArea(value);
        Volume = CalculateVolume(value);
        Density = CalculateDensity(_mass, value);
      }
    }

    /// <summary>
    ///   Represents the planet's mass in <c>Earth Mass</c>.
    ///   The value of 1 Earth Mass is <c>5.9722e27</c>.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <c>mass</c> is lesser or equal to zero.</exception>
    public double Mass
    {
      get => _mass;
      set
      {
        if (value <= 0)
        {
          throw new ArgumentOutOfRangeException(nameof(value), "Mass must be greater than 0ME.");
        }
        _mass = value;
        Density = CalculateDensity(value, _radius);
      }
    }

    /// <summary>
    ///   Represents the planet's area in <c>km^2</c>.
    /// </summary>
    public double Area { get; private set; }

    /// <summary>
    ///   Represents the planet's volume in <c>km^3</c>.
    /// </summary>
    public double Volume { get; private set; }

    /// <summary>
    ///   Represents the planet's density in <c>g/cm^3</c>.
    /// </summary>
    public double Density { get; private set; }

    /// <summary>
    ///   Determines which of two Planets has the largest radius.
    /// </summary>
    /// <param name="value"> the object to be compared to the current object.</param>
    /// <returns>Planet object that is the largest.</returns>
    public Planet GetLargestPlanet(Planet value)
    {
      return Volume > value.Volume ? this : value;
    }

    /// <summary>
    ///   Determines which of two Planets is the most dense.
    /// </summary>
    /// <param name="value"> the object to be compared to the current object.</param>
    /// <returns>Planet object that is the most dense.</returns>
    public Planet GetMostDensePlanet(Planet value)
    {
      return Density > value.Density ? this : value;
    }

    /// <summary>
    ///   Determines whether two Planets have the same radius and mass.
    /// </summary>
    /// <param name="value"> the object to be compared to the current object.</param>
    /// <returns>True if the Planets have the same radius and mass; otherwise, false.</returns>
    public bool Equals(Planet value)
    {
      return Equals(_radius, value._radius) && Equals(_mass, value._mass);
    }

    /// <summary>
    ///   Determines whether a planet has a smaller, equal or larger radius compared to another planet.
    /// </summary>
    /// <param name="value"> the object to be compared to the current object.</param>
    /// <returns>
    ///   -1 if the current planet is smaller;
    ///   0 if both planets are equal;
    ///   1 if the current planet is bigger;
    /// </returns>
    public int CompareTo(Planet value)
    {
      return _radius.CompareTo(value._radius);
    }

    /// <summary>
    ///   Calculates the volume of a sphere.
    /// </summary>
    /// <param name="radius">The radius of the sphere to calculate.</param>
    /// <returns>Double representing the volume.</returns>
    private static double CalculateVolume(double radius)
    {
      return 4.0 / 3.0 * Math.PI * Math.Pow(radius, 3);
    }

    /// <summary>
    ///   Calculates the area of a sphere.
    /// </summary>
    /// <param name="radius">The radius of the sphere to calculate.</param>
    /// <returns>Double representing the area.</returns>
    private static double CalculateArea(double radius)
    {
      return 4 * Math.PI * Math.Pow(radius, 2);
    }

    /// <summary>
    ///   Calculates the density of a planet.
    /// </summary>
    /// <param name="mass">The mass of the planet.</param>
    /// <param name="radius">The radius of the planet.</param>
    /// <returns>Double representing the density.</returns>
    private double CalculateDensity(double mass, double radius)
    {
      return mass * EarthMass / CalculateVolume(radius * 1e5);
    }

    /// <summary>
    ///   Reports the statistics of a planet.
    /// </summary>
    /// <returns>
    ///   String representing all the properties of a planet, in the form <code>Property: Value,</code>, with it's
    ///   appropriate unit.
    /// </returns>
    public override string ToString()
    {
      return
        $"{nameof(Name)}: {Name}, " +
        $"{nameof(Radius)}: {Radius:N2}km, " +
        $"{nameof(Mass)}: {Mass:N2}ME, " +
        $"{nameof(Area)}: {Area:G2}km2, " +
        $"{nameof(Volume)}: {Volume:G2}km3, " +
        $"{nameof(Density)}: {Density:F2}g/cm3";
    }
  }
}