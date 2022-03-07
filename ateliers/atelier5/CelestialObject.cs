namespace atelier5
{
  public abstract class CelestialObject
  {

    /// <summary>
    /// Represents the name of the celestial body.
    /// </summary>
    private string _name;
    
    /// <summary>
    ///   Represents the celestial body's name.
    /// </summary>
    public string Name
    {
      get => _name;
      set => _name = value;
    }

    protected CelestialObject()
    {
      _name = "Unknown";
    }

    protected CelestialObject(string name)
    {
      _name = name;
    }
  }
}