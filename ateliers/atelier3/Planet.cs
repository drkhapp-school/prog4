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
    ///   Represents the area of the planet.
    /// </summary>
    private double _area;

    /// <summary>
    ///   Represents the density of the planet.
    /// </summary>
    private double _density;

    /// <summary>
    ///   Represents the mass of the planet.
    /// </summary>
    private double _mass;

    /// <summary>
    ///   Represents the name of the planet.
    /// </summary>
    private string _name;

    /// <summary>
    ///   Represents the radius of the planet.
    /// </summary>
    private double _radius;

    /// <summary>
    ///   Represents the volume of the planet.
    /// </summary>
    private double _volume;

    /// <summary>
    ///   Initializes a new planet.
    /// </summary>
    /// <param name="name"> the new planet's name.</param>
    /// <param name="radius"> the new planet's radius, in km.</param>
    /// <param name="mass"> the new planet's mass, in Earth Mass.</param>
    public Planet(string name, double radius, double mass)
    {
      Name = name;
      Radius = radius;
      Mass = mass;
    }

    /// <summary>
    ///   Represents the planet's name.
    /// </summary>
    public string Name
    {
      get => _name;
      set => _name = value;
    }

    /// <value>
    ///   Represents the planet's radius in <c>km</c>.
    /// </value>
    public double Radius
    {
      get => _radius;
      set
      {
        _radius = value;
        _area = CalculateArea(value);
        _volume = CalculateVolume(value);
        _density = CalculateDensity(_mass, value);
      }
    }

    /// <value>
    ///   Represents the planet's mass in <c>Earth Mass</c>.
    ///   The value of 1 Earth Mass is <c>5.9722e27</c>.
    /// </value>
    public double Mass
    {
      get => _mass;
      set
      {
        _mass = value;
        _density = CalculateDensity(value, _radius);
      }
    }

    /// <value>
    ///   Represents the planet's area in <c>km^2</c>.
    /// </value>
    public double Area
    {
      get => _area;
    }

    /// <value>
    ///   Represents the planet's volume in <c>km^3</c>.
    /// </value>
    public double Volume
    {
      get => _volume;
    }

    /// <value>
    ///   Represents the planet's density in <c>g/cm^3</c>.
    /// </value>
    public double Density
    {
      get => _density; 
    }

    /// <summary>
    ///   Determines which of two Planets has the largest radius.
    /// </summary>
    /// <param name="value"> the object to be compared to the current object.</param>
    /// <returns>Planet object that is the largest.</returns>
    public Planet GetLargestPlanet(Planet value)
    {
      return _volume > value._volume ? this : value;
    }

    /// <summary>
    ///   Determines which of two Planets is the most dense.
    /// </summary>
    /// <param name="value"> the object to be compared to the current object.</param>
    /// <returns>Planet object that is the most dense.</returns>
    public Planet GetMostDensePlanet(Planet value)
    {
      return _density > value._density ? this : value;
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
    private double CalculateVolume(double radius)
    {
      return 4.0 / 3.0 * Math.PI * Math.Pow(radius, 3);
    }

    /// <summary>
    ///   Calculates the area of a sphere.
    /// </summary>
    /// <param name="radius">The radius of the sphere to calculate.</param>
    /// <returns>Double representing the area.</returns>
    private double CalculateArea(double radius)
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