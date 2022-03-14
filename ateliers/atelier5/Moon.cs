namespace atelier5
{
  public class Moon : CelestialBody
  {
    /// <summary>
    ///   Initializes a new moon.
    /// </summary>
    /// <param name="name">The name of the moon.</param>
    /// <param name="radius">The radius of the moon.</param>
    /// <param name="mass">The mass of the moon.</param>
    /// <param name="parent">The planet that the moon orbits.</param>
    public Moon(CelestialObject parent, string name, double radius, double mass) : base(parent, name, radius, mass)
    {
    }

    /// <summary>
    ///   Initializes a new moon with an unknown radius and mass.
    /// </summary>
    /// <param name="name">The name of the moon.</param>
    /// <param name="parent">The planet that the moon orbits.</param>
    public Moon(CelestialObject parent, string name) : base(parent, name)
    {
    }

    /// <summary>
    ///   Initializes a new moon with an unknown name, radius and mass.
    /// </summary>
    public Moon(CelestialObject parent) : base (parent)
    {
    }
  }
}