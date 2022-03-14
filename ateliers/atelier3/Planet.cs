using System;

namespace atelier3
{
  /// <summary>
  ///   Represents a planet.
  /// </summary>
  public class Planet : IComparable
  {
    /// <summary>
    ///   Represents the equivalent of 1 Earth Mass in <c>kg</c>.
    /// </summary>
    public const double EarthMass = 5.9722e27;

    /// <summary>
    ///   Represents a unique identifier for a Planet.
    /// </summary>
    private readonly Guid _id;

    /// <summary>
    ///   Represents the planet's mass in <c>Earth Mass</c>.
    ///   The value of 1 Earth Mass is <c>5.9722e27</c>.
    /// </summary>
    /// <remarks>A value of -1 means an unknown mass.</remarks>
    private double? _mass;

    /// <summary>
    ///   Represents the planet's radius in <c>km</c>.
    /// </summary>
    /// <remarks>A value of -1 means an unknown radius.</remarks>
    private double? _radius;

    /// <summary>
    ///   Initializes a new planet.
    /// </summary>
    /// <param name="name"> the new planet's name.</param>
    /// <param name="radius"> the new planet's radius, in km.</param>
    /// <param name="mass"> the new planet's mass, in Earth Mass.</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <c>radius</c> or <c>mass</c> is lesser or equal to zero.</exception>
    public Planet(string name, double radius, double mass)
    {
      _id = Guid.NewGuid();
      Name = name;
      Radius = radius;
      Mass = mass;
    }

    /// <summary>
    ///   Initializes a new planet with an unknown radius and mass.
    /// </summary>
    /// <param name="name"> the new planet's name.</param>
    public Planet(string name)
    {
      _id = Guid.NewGuid();
      Name = name;
      Radius = null;
      Mass = null;
    }

    /// <summary>
    ///   Represents the planet's name.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    ///   Represents the planet's radius in <c>km</c>.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <c>radius</c> is lesser or equal to zero, and is not null.</exception>
    /// <remarks>A value of -1 means an unknown radius.</remarks>
    public double? Radius
    {
      get => _radius ?? -1;
      set
      {
        if (value <= 0)
          throw new ArgumentOutOfRangeException(nameof(value),
            "Radius must be greater than 0km. Use null if you want to clear the radius.");

        _radius = value ?? -1;
      }
    }

    /// <summary>
    ///   Represents the planet's mass in <c>Earth Mass</c>.
    ///   The value of 1 Earth Mass is <c>5.9722e27</c>.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <c>mass</c> is lesser or equal to zero, and is not null.</exception>
    /// <remarks>A value of -1 means an unknown mass.</remarks>
    public double? Mass
    {
      get => _mass ?? -1;
      set
      {
        if (value <= 0)
          throw new ArgumentOutOfRangeException(nameof(value), "Mass must be greater than 0ME.");

        _mass = value ?? -1;
      }
    }

    /// <summary>
    ///   Represents the planet's area in <c>km^2</c>.
    /// </summary>
    /// <remarks>A value of -1 means an unknown area, due to an unknown radius.</remarks>
    public double Area => CalculateArea(_radius);

    /// <summary>
    ///   Represents the planet's volume in <c>km^3</c>.
    /// </summary>
    /// <remarks>A value of -1 means an unknown volume, due to an unknown radius.</remarks>
    public double Volume => CalculateVolume(_radius);

    /// <summary>
    ///   Represents the planet's density in <c>g/cm^3</c>.
    /// </summary>
    /// <remarks>A value of -1 means an unknown density, due to an unknown mass or radius.</remarks>
    public double Density => CalculateDensity(_mass, _radius);

    /// <summary>
    ///   <para>
    ///     Compares the current Planet with another Planet and returns an integer that indicates whether the current
    ///     Planet precedes, follows, or occurs in the same position in the sort order as the other object.
    ///   </para>
    ///   <para>Planets are sorted by their radius.</para>
    /// </summary>
    /// <param name="obj"> The Planet to be compared to the current Planet.</param>
    /// <returns>
    ///   -1 if the current planet is smaller;
    ///   0 if both planets are equal;
    ///   1 if the current planet is bigger;
    /// </returns>
    public int CompareTo(object obj)
    {
      if (obj == null) return 1;
      if (obj.GetType() != GetType()) throw new ArgumentException("Cannot compare a planet to another type of object.");
      return CompareTo((Planet) obj);
    }

    /// <summary>
    ///   Determines which of two Planets has the largest radius.
    /// </summary>
    /// <param name="value"> The Planet to be compared to the current Planet.</param>
    /// <returns>The Planet that is the largest.</returns>
    public Planet GetLargestPlanet(Planet value)
    {
      return Volume > value.Volume ? this : value;
    }

    /// <summary>
    ///   Determines which of two Planets is the most dense.
    /// </summary>
    /// <param name="value"> The Planet to be compared to the current Planet.</param>
    /// <returns>The Planet that is the most dense.</returns>
    public Planet GetMostDensePlanet(Planet value)
    {
      return Density > value.Density ? this : value;
    }

    /// <summary>
    ///   Determines whether the specified planet has the same name, radius and mass as the current planet.
    /// </summary>
    /// <param name="obj"> The Planet to be compared to the current Planet.</param>
    /// <returns>True if the Planets have the same name, radius and mass; otherwise, false.</returns>
    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      return obj.GetType() == GetType() && Equals((Planet) obj);
    }

    public override int GetHashCode()
    {
      return _id.GetHashCode();
    }

    private bool Equals(Planet other)
    {
      return Mass.Equals(other.Mass) && Radius.Equals(other.Radius) && Name.Equals(other.Name);
    }

    private int CompareTo(Planet value)
    {
      return Nullable.Compare(_radius, value._radius);
    }

    /// <summary>
    ///   Calculates the volume of a sphere.
    /// </summary>
    /// <param name="radius">The radius of the sphere to calculate.</param>
    /// <returns>Double representing the volume, or -1 if the radius is null.</returns>
    private static double CalculateVolume(double? radius)
    {
      return radius.HasValue ? 4.0 / 3.0 * Math.PI * Math.Pow((double) radius, 3) : -1;
    }

    /// <summary>
    ///   Calculates the area of a sphere.
    /// </summary>
    /// <param name="radius">The radius of the sphere to calculate.</param>
    /// <returns>Double representing the area, or -1 if the radius is null.</returns>
    private static double CalculateArea(double? radius)
    {
      return radius.HasValue ? 4 * Math.PI * Math.Pow((double) radius, 2) : -1;
    }

    /// <summary>
    ///   Calculates the density of a planet.
    /// </summary>
    /// <param name="mass">The mass of the planet.</param>
    /// <param name="radius">The radius of the planet.</param>
    /// <returns>Double representing the density, or -1 if any parameter is null.</returns>
    private static double CalculateDensity(double? mass, double? radius)
    {
      return mass.HasValue && radius.HasValue
        ? (double) mass * EarthMass / CalculateVolume(radius * 1e5)
        : -1;
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