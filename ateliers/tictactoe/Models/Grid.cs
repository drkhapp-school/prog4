namespace tictactoe.Models
{
  public class Grid
  {
    private Cell[] _cells;

    public Grid()
    {
      _cells = new Cell[9];
      for (int i = 0; i < 9; i++)
      {
        _cells[i] = new Cell();
      }
    }

    public Cell[] Cells => _cells;

    public Symbol this[int i]
    {
      get => _cells[i].Symbol;
      set => _cells[i].Symbol = value;
    }
    
    public Cell this[int i, int j]
    {
      get => _cells[i + j % 3];
      set => _cells[i + j % 3] = value;
    }

    public bool IsEmpty(int index)
    {
      return _cells[index].Symbol == Symbol.Empty;
    }
  }
}