using System;

namespace atelier3
{
  public class Planet
  {
    public string Name
    {
      get => _name;
      set => _name = value;
    }

    public int Radius
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

    public float Mass
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
      get => _density;
    }

    private string _name;
    private int _radius;
    private float _mass;
    private double _area;
    private double _volume;
    private double _density;

    public Planet(string name, int radius, float mass)
    {
      _name = name;
      _radius = radius;
      _mass = mass;
      _area = CalculateArea(radius);
      _volume = CalculateVolume(radius); 
      _density = CalculateDensity(mass, radius);
    }

    public Planet GetLargestPlanet(Planet a, Planet b)
    {
      return a._volume > b._volume ? a : b;
    }

    public Planet GetMostDensePlanet(Planet a, Planet b)
    {
      return a._density > b._density ? a : b;
    }

    public bool IsDuplicatePlanet(Planet a, Planet b)
    {
      return a._name == b._name && a._radius == b._radius && a._mass == b._mass;
    }

    public int ComparePlanets(Planet a, Planet b)
    {
      return a._radius.CompareTo(b._radius);
    }

    private double CalculateVolume(int radius)
    {
      return 4.0 / 3.0 * Math.PI * Math.Pow(radius, 3);
    }
    
    private double CalculateArea(int radius)
    {
      return 4 * Math.PI * Math.Pow(radius, 2);
    }
    
    private double CalculateDensity(float mass, int radius)
    {
      return mass / CalculateVolume(radius);
    }
  }
}