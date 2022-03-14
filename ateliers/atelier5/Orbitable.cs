namespace atelier5
{
  public abstract class Orbitable : CelestialObject
  {
    private CelestialObject _parent;

    protected Orbitable(CelestialObject parent)
    {
      _parent = parent;
      _parent.AddCelestialObject(this);
    }

    protected Orbitable(CelestialObject parent, string name) : base(name)
    {
      _parent = parent;
      _parent.AddCelestialObject(this);
    }

    public override void AddCelestialObject(Orbitable child)
    {
      _parent.AddCelestialObject(child);
    }

    public CelestialObject Parent
    {
      get => _parent;
      set
      {
        _parent = value;
      }
    }
  }
}