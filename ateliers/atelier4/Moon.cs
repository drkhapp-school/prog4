using System;

namespace atelier4
{
  public class Moon : IComparable
  {
    /// <summary>
    ///   Represents the equivalent of 1 Earth Mass in <c>kg</c>.
    /// </summary>
    public const double EarthMass = 5.9722e27;

    /// <summary>
    ///   Represents a unique identifier for a Moon.
    /// </summary>
    private readonly Guid _id;


    /// <summary>
    ///   Represents the Moon's mass in <c>Earth Mass</c>.
    ///   The value of 1 Earth Mass is <c>5.9722e27</c>.
    /// </summary>
    /// <remarks>A value of -1 means an unknown mass.</remarks>
    private double? _mass;

    /// <summary>
    ///   Represents the Moon's radius in <c>km</c>.
    /// </summary>
    /// <remarks>A value of -1 means an unknown radius.</remarks>
    private double? _radius;

    /// <summary>
    ///   Initializes a new Moon.
    /// </summary>
    /// <param name="name"> the new Moon's name.</param>
    /// <param name="radius"> the new Moon's radius, in km.</param>
    /// <param name="mass"> the new Moon's mass, in Earth Mass.</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <c>radius</c> or <c>mass</c> is lesser or equal to zero.</exception>
    public Moon(string name, double radius, double mass)
    {
      _id = Guid.NewGuid();
      Name = name;
      Radius = radius;
      Mass = mass;
    }

    /// <summary>
    ///   Initializes a new Moon with an unknown radius and mass.
    /// </summary>
    /// <param name="name"> the new Moon's name.</param>
    public Moon(string name)
    {
      _id = Guid.NewGuid();
      Name = name;
      Radius = null;
      Mass = null;
    }

    /// <summary>
    ///   Represents the Moon's name.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    ///   Represents the Moon's radius in <c>km</c>.
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
    ///   Represents the Moon's mass in <c>Earth Mass</c>.
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
    ///   Represents the Moon's area in <c>km^2</c>.
    /// </summary>
    /// <remarks>A value of -1 means an unknown area, due to an unknown radius.</remarks>
    public double? Area => CalculateArea(_radius);

    /// <summary>
    ///   Represents the Moon's volume in <c>km^3</c>.
    /// </summary>
    /// <remarks>A value of -1 means an unknown volume, due to an unknown radius.</remarks>
    public double? Volume => CalculateVolume(_radius);

    /// <summary>
    ///   Represents the Moon's density in <c>g/cm^3</c>.
    /// </summary>
    /// <remarks>A value of -1 means an unknown density, due to an unknown mass or radius.</remarks>
    public double? Density => CalculateDensity(_mass, _radius);

    /// <summary>
    ///   <para>
    ///     Compares the current Moon with another Moon and returns an integer that indicates whether the current Moon
    ///     precedes, follows, or occurs in the same position in the sort order as the other object.
    ///   </para>
    ///   <para>Moons are sorted by their radius.</para>
    /// </summary>
    /// <param name="obj"> The Moon to be compared to the current Moon.</param>
    /// <returns>
    ///   -1 if the current Moon is smaller;
    ///   0 if both Moons are equal;
    ///   1 if the current Moon is bigger;
    /// </returns>
    public int CompareTo(object obj)
    {
      if (obj == null) return 1;
      if (obj.GetType() != GetType()) throw new ArgumentException("Cannot compare a Moon to another type of object.");
      return CompareTo((Moon) obj);
    }

    /// <summary>
    ///   Determines which of two Moons has the largest radius.
    /// </summary>
    /// <param name="value"> The Moon to be compared to the current Moon.</param>
    /// <returns>The Moon that is the largest.</returns>
    public Moon GetLargestMoon(Moon value)
    {
      return Volume > value.Volume ? this : value;
    }

    /// <summary>
    ///   Determines which of two Moons is the most dense.
    /// </summary>
    /// <param name="value"> The Moon to be compared to the current Moon.</param>
    /// <returns>The Moon that is the most dense.</returns>
    public Moon GetMostDenseMoon(Moon value)
    {
      return Density > value.Density ? this : value;
    }

    /// <summary>
    ///   Determines whether the specified Moon has the same name, radius and mass as the current Moon.
    /// </summary>
    /// <param name="obj"> The Moon to be compared to the current Moon.</param>
    /// <returns>True if the Moons have the same name, radius and mass; otherwise, false.</returns>
    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      return obj.GetType() == GetType() && Equals((Moon) obj);
    }

    public override int GetHashCode()
    {
      return _id.GetHashCode();
    }

    private bool Equals(Moon other)
    {
      return Mass.Equals(other.Mass) && Radius.Equals(other.Radius) && Name.Equals(other.Name);
    }

    private int CompareTo(Moon value)
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
    ///   Calculates the density of a moon.
    /// </summary>
    /// <param name="mass">The mass of the moon.</param>
    /// <param name="radius">The radius of the moon.</param>
    /// <returns>Double representing the density, or -1 if any parameter is null.</returns>
    private static double CalculateDensity(double? mass, double? radius)
    {
      return mass.HasValue && radius.HasValue
        ? (double) mass * EarthMass / CalculateVolume(radius * 1e5)
        : -1;
    }

    /// <summary>
    ///   Reports the statistics of a moon.
    /// </summary>
    /// <returns>
    ///   String representing all the properties of a moon, in the form <code>Property: Value,</code>, with it's
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