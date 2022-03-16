namespace tictactoe.Models
{
  public class Grid
  {
    private Cell[] _cells;

    public Grid()
    {
      _cells = new Cell[9];
      for (int i = 0; i < 8; i++)
      {
        _cells[i] = new Cell();
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