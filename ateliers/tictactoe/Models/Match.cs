using System;
using tictactoe.Controllers;

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
      
      _grid[index].Symbol = _current.Symbol;
      _current = _current == _x ? _o : _x;
      return true;
    }

    public Symbol GetCurrent()
    {
      return _current.Symbol;
    }

    public bool Victory()
    {
      throw new NotImplementedException();
    }
  }
}