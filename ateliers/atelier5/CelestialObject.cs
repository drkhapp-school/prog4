namespace atelier5
{
  public abstract class CelestialObject
  {
    /// <summary>
    ///   Represents the name of the celestial object.
    /// </summary>
    private string _name;

    /// <summary>
    ///   Initializes a new celestial object with an unknown name.
    /// </summary>
    protected CelestialObject()
    {
      _name = "Unknown";
    }

    /// <summary>
    ///   Initializes a new celestial object.
    /// </summary>
    /// <param name="name">The name of the celestial object.</param>
    protected CelestialObject(string name)
    {
      _name = name;
    }

    /// <summary>
    ///   Represents the celestial object's name.
    /// </summary>
    public string Name
    {
      get => _name;
      set => _name = value;
    }

    /// <summary>
    ///   Returns information about the celestial object.
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
      return $"{GetType().Name} {Name}";
    }
  }
}