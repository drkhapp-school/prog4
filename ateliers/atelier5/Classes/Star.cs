namespace atelier5.Classes
{
  public class Star : CelestialBodyWithCore
  {
    public Star()
    {
    }

    public Star(string name) : base(name)
    {
    }

    public Star(string name, double radius, double mass) : base(name, radius, mass)
    {
    }

    public Star(string name, double radius, double mass, double coreSize, double corona) : base(name, radius, mass,
      coreSize)
    {
    }
  }
}