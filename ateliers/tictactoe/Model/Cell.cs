namespace tictactoe
{
  public class Cell
  {
    private Symbol _symbol;

    public Cell()
    {
      _symbol = Symbol.Empty;
    }

    public Symbol Symbol
    {
      get => _symbol;
      set => _symbol = value;
    }
  }
}