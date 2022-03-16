namespace tictactoe.Models
{
  public class User
  {
    
    private string _name;
    private uint _points;

    public User(string name)
    {
      _name = name;
      _points = 0;
    }

    public string Name
    {
      get => _name;
      set => _name = value;
    }
    
    public uint Points
    {
      get => _points;
      set => _points = value;
    }
  }
}