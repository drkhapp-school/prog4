namespace tictactoe.Models
{
  public class Match
  {
    private GameController _controller;
    private Player _current;
    private Player _x;
    private Player _o;
    private Grid _grid;

    public Match(GameController controller, User x, User o)
    {
      _controller = controller;
      _x = new Player(x.Name, Symbol.X);
      _o = new Player(o.Name, Symbol.O);
      _current = _x;
      _grid = new Grid();
    }

    public bool Turn(int index)
    {
      if (!_grid.IsEmpty(index)) return false;

      _grid[index] = _current.Symbol;
      _current = _current == _x ? _o : _x;
      return true;
    }

    public Symbol GetCurrent()
    {
      return _current.Symbol;
    }

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