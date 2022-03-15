namespace tictactoe
{
  public class Grid
  {
    private Cell[] _cells;

    public Grid()
    {
      _cells = new Cell[9];
      foreach (var box in _cells)
      {
        box.Symbol = Symbol.Empty;
      }
    }

    public Cell[] Cells => _cells;

    public Cell this[int i]
    {
      get => _cells[i];
      set => _cells[i] = value;
    }

    public bool IsEmpty(int index)
    {
      return _cells[index].Symbol == Symbol.Empty;
    } 
  }
}