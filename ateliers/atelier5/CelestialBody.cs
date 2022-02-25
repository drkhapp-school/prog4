using System;

namespace atelier5
{
  public abstract class CelestialBody : IComparable
  {
    /// <summary>
    ///   Represents the equivalent of 1 Earth Mass in <c>kg</c>.
    /// </summary>
    private const double EarthMass = 5.9722e27;

    /// <summary>
    ///   Represents the equivalent of 1 Solar Mass in <c>Earth Mass</c>.
    /// </summary>
    private const double SolarMass = 333000;

    /// <summary>
    ///   Represents the celestial body's mass in <c>Earth Mass</c>.
    ///   The value of 1 Earth Mass is <c>5.9722e27</c>.
    /// </summary>
    /// <remarks>A value of 0 means an unknown mass.</remarks>
    private double _mass;

    /// <summary>
    /// Represents the name of the celestial body.
    /// </summary>
    private string _name;

    /// <summary>
    ///   Represents the celestial body's radius in <c>km</c>.
    /// </summary>
    /// <remarks>A value of 0 means an unknown radius.</remarks>
    private double _radius;

    /// <summary>
    ///   Initializes a new celestial body.
    /// </summary>
    /// <param name="name"> the new celestial body's name.</param>
    /// <param name="radius"> the new celestial body's radius, in km.</param>
    /// <param name="mass"> the new celestial body's mass, in Earth Mass.</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <c>radius</c> or <c>mass</c> is set to a value lesser than to zero.</exception>
    protected CelestialBody(string name, double radius, double mass)
    {
      Name = name;
      Radius = radius;
      Mass = mass;
    }

    /// <summary>
    ///   Initializes a new celestial body with an unknown radius and mass.
    /// </summary>
    /// <param name="name"> the new planet's name.</param>
    protected CelestialBody(string name)
    {
      Name = name;
      Radius = 0;
      Mass = 0;
    }

    /// <summary>
    ///   Initializes a new celestial body with an unknown name, radius and mass.
    /// </summary>
    protected CelestialBody()
    {
      Name = "Unknown";
      Radius = 0;
      Mass = 0;
    }

    /// <summary>
    ///   Represents the planet's name.
    /// </summary>
    public string Name
    {
      get => _name;
      set => _name = value;
    }

    /// <summary>
    ///   Represents the celestial body's radius in <c>km</c>.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <c>radius</c> is set to a value lesser than zero.</exception>
    /// <remarks>A value of 0 means an unknown radius.</remarks>
    public double Radius
    {
      get => _radius;
      set
      {
        if (value < 0)
          throw new ArgumentOutOfRangeException(nameof(value),
            "Radius must be greater than 0km. Use null if you want to clear the radius.");

        _radius = value;
      }
    }

    /// <summary>
    ///   Represents the celestial body's mass in <c>Earth Mass</c>.
    ///   The value of 1 Earth Mass is <c>5.9722e27</c>.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <c>mass</c> is set to a value lesser than zero.</exception>
    /// <remarks>A value of 0 means an unknown mass.</remarks>
    public double Mass
    {
      get => _mass;
      set
      {
        if (value < 0)
          throw new ArgumentOutOfRangeException(nameof(value), "Mass must be greater than 0ME.");

        _mass = value;
      }
    }

    /// <summary>
    ///   Represents the celestial body's area in <c>km^2</c>.
    /// </summary>
    /// <remarks>A value of 0 means an unknown area, due to an unknown radius.</remarks>
    public double Area => CalculateArea(_radius);

    /// <summary>
    ///   Represents the celestial body's volume in <c>km^3</c>.
    /// </summary>
    /// <remarks>A value of 0 means an unknown volume, due to an unknown radius.</remarks>
    public double Volume => CalculateVolume(_radius);

    /// <summary>
    ///   Represents the celestial body's density in <c>g/cm^3</c>.
    /// </summary>
    /// <remarks>A value of 0 means an unknown density, due to an unknown mass or radius.</remarks>
    public double Density => CalculateDensity(_mass, _radius);

    /// <summary>
    ///   <para>
    ///     Compares the current Celestial Body with another Celestial Body and returns an integer that indicates whether the current
    ///     Celestial Body precedes, follows, or occurs in the same position in the sort order as the other object.
    ///   </para>
    ///   <para>Celestial Bodies are sorted by their radius.</para>
    /// </summary>
    /// <param name="obj"> The celestial body to be compared to the current celestial body.</param>
    /// <returns>
    ///   -1 if the current body is smaller;
    ///   0 if both bodies are equal;
    ///   1 if the current body is larger;
    /// </returns>
    public int CompareTo(object obj)
    {
      if (obj == null) return 1;
      if (obj.GetType() != GetType())
        throw new ArgumentException("Cannot compare a celestial body to another type of object.");
      return CompareTo((CelestialBody) obj);
    }


    /// <summary>
    ///   Determines which of two Celestial Bodies has the largest radius.
    /// </summary>
    /// <param name="value"> The Celestial Body to be compared to the current Celestial Body.</param>
    /// <returns>The Celestial Body that is the largest.</returns>
    public CelestialBody GetLargest(CelestialBody value)
    {
      return Volume > value.Volume ? this : value;
    }

    /// <summary>
    ///   Determines which of two Celestial bodies is the most dense.
    /// </summary>
    /// <param name="value"> The Celestial Body to be compared to the current Celestial Body.</param>
    /// <returns>The Celestial Body that is the most dense.</returns>
    public CelestialBody GetMostDense(CelestialBody value)
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
      return obj.GetType() == GetType() && Equals((CelestialBody) obj);
    }

    public override int GetHashCode()
    {
      unchecked
      {
        var hashCode = _mass.GetHashCode();
        hashCode = (hashCode * 397) ^ _radius.GetHashCode();
        hashCode = (hashCode * 397) ^ (Name != null ? Name.GetHashCode() : 0);
        return hashCode;
      }
    }

    private bool Equals(CelestialBody other)
    {
      return Mass.Equals(other.Mass) && Radius.Equals(other.Radius) && Name.Equals(other.Name);
    }

    private int CompareTo(CelestialBody value)
    {
      return _radius < value._radius ? -1 : _radius > value._radius ? 1 : 0;
    }

    /// <summary>
    ///   Calculates the volume of a sphere.
    /// </summary>
    /// <param name="radius">The radius of the sphere to calculate.</param>
    /// <returns>Double representing the volume, or -1 if the radius is null.</returns>
    private static double CalculateVolume(double? radius)
    {
      return radius.HasValue ? 4.0 / 3.0 * Math.PI * Math.Pow((double) radius, 3) : 0;
    }

    /// <summary>
    ///   Calculates the area of a sphere.
    /// </summary>
    /// <param name="radius">The radius of the sphere to calculate.</param>
    /// <returns>Double representing the area, or -1 if the radius is null.</returns>
    private static double CalculateArea(double? radius)
    {
      return radius.HasValue ? 4 * Math.PI * Math.Pow((double) radius, 2) : 0;
    }

    /// <summary>
    ///   Calculates the density of a celestial body.
    /// </summary>
    /// <param name="mass">The mass of the celestial body.</param>
    /// <param name="radius">The radius of the celestial body.</param>
    /// <returns>Double representing the density, or -1 if any parameter is null.</returns>
    private static double CalculateDensity(double? mass, double? radius)
    {
      return mass.HasValue && radius.HasValue
        ? (double) mass * EarthMass / CalculateVolume(radius * 1e5)
        : -1;
    }

    /// <summary>
    ///   Reports the statistics of a celestial body.
    /// </summary>
    /// <returns>
    ///   String representing all the properties of a celestial body, in the form <code>Property: Value,</code>, with it's
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