namespace tictactoe.Models
{
  public class Player : User
  {
    private Symbol _symbol;

    public Player(string name, Symbol symbol) : base(name)
    {
      _symbol = symbol;
    }

    public Symbol Symbol
    {
      get => _symbol;
      set => _symbol = value;
    }
  }
}