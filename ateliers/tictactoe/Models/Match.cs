namespace tictactoe.Models
{
  public class Match
  {
    private GameController _controller;
    private Symbol _current;
    private Grid _grid;

    public Match(GameController controller)
    {
      _controller = controller;
      _current = Symbol.X;
      _grid = new Grid();
    }

    public bool Turn(int index)
    {
      if (!_grid.IsEmpty(index)) return false;

      _grid[index] = _current;
      _current = _current == Symbol.X ? Symbol.X : Symbol.O;
      return true;
    }
    
    public bool FullGrid()
    {
      foreach (var cell in _grid.Cells)
        if (cell.Symbol == Symbol.Empty)
          return false;

      return true;
    }

    public Symbol Current => _current;

    public bool InRow(int index)
    {
      var y = index % 3;
      return _grid[y] == _grid[y + 3] && _grid[y] == _grid[y + 6];
    }

    public bool InColumn(int index)
    {
      var x = index / 3;
      return _grid[x * 3] == _grid[x * 3 + 1] && _grid[x * 3] == _grid[x * 3 + 2];
    }

    public bool InDiagonal()
    {
      return _grid[0] == _grid[4] && _grid[0] == _grid[8] && _grid[0] != Symbol.Empty ||
             _grid[6] == _grid[4] && _grid[6] == _grid[2] && _grid[6] != Symbol.Empty;
    }
  }
}