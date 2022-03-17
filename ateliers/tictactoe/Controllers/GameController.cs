using tictactoe.Models;

namespace tictactoe
{
  public class GameController : Controller
  {
    private Match _match;
    private User _first;
    private User _second;

    public GameController(TicTacToe main, User first, User second) : base(main)
    {
      Main = main;
      _match = new Match(this, first, second);
      _first = first;
      _second = second;
    }

    public bool Turn(int index)
    {
      return _match.Turn(index);
    }

    public bool Victory()
    {
      return _match.Victory();
    }
  }
}