using System.Collections.Generic;

namespace atelier5
{
  public class Galaxy
  {
    private string _name;
    private string _type;
    private List<SolarSystem> _systems;

    public Galaxy(string name, string type)
    {
      _name = name;
      _type = type;
      _systems = new List<SolarSystem>();
    }

    public Galaxy(string name)
    {
      _name = name;
      _type = "Unknown";
      _systems = new List<SolarSystem>();
    }

    public Galaxy()
    {
      _name = "Unknown";
      _type = "Unknown";
      _systems = new List<SolarSystem>();
    }

    public string Name
    {
      get => _name;
      set => _name = value;
    }

    public string Type
    {
      get => _type;
      set => _type = value;
    }

    public SolarSystem this[int i] => _systems[i];

    public void Add(SolarSystem solarSystem)
    {
      if (_systems.Contains(solarSystem)) return;
      _systems.Add(solarSystem);
    }
  }
}