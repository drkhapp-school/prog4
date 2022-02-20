using System;

namespace atelier3
{
  public class Planet
  {
    private const double EarthMass = 5.9722e27;
    public string Name
    {
      get => _name;
      set => _name = value;
    }

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

    public double Mass
    {
      get => _mass;
      set
      {
        _mass = value;
        _density = CalculateDensity(value, _radius);
      }
    }

    public double Area
    {
      get => _area;
    }

    public double Volume
    {
      get => _volume;
    }

    public double Density
    {
      get =>

        // Density is measured in g/cm^3, however we store Density in earthMass/km^3.
        _density;
    }

    private string _name;
    private double _radius;
    private double _mass;
    private double _volume;
    private double _area;
    private double _density;

    public Planet(string name, double radius, double mass)
    {
      Name = name;
      Radius = radius;
      Mass = mass;
    }

    public Planet GetLargestPlanet(Planet a, Planet b)
    {
      return a.Volume > b.Volume ? a : b;
    }

    public Planet GetMostDensePlanet(Planet a, Planet b)
    {
      return a._density > b._density ? a : b;
    }

    public bool IsDuplicatePlanet(Planet a, Planet b)
    {
      return Equals(a._name, b._name) && Equals(a._radius, b._radius) && Equals(a._mass, b._mass);
    }

    public int ComparePlanets(Planet a, Planet b)
    {
      return a._radius.CompareTo(b._radius);
    }

    private double CalculateVolume(double radius)
    {
      return 4.0 / 3.0 * Math.PI * Math.Pow(radius, 3);
    }

    private double CalculateArea(double radius)
    {
      return 4 * Math.PI * Math.Pow(radius, 2);
    }

    private double CalculateDensity(double mass, double radius)
    {
      return mass * EarthMass / CalculateVolume(radius * 1e5);
    }

    public override string ToString()
    {
      // By default, ToString will return easy to read numbers.
      return
        $"{nameof(Name)}: {Name}, {nameof(Radius)}: {Radius:F}km, {nameof(Mass)}: {Mass:F}ME, {nameof(Area)}: {Area:G}km2, {nameof(Volume)}: {Volume:G}km3, {nameof(Density)}: {Density:F}g/cm3";
    }
  }
}