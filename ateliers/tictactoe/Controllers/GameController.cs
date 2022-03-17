using tictactoe.Models;

namespace tictactoe
{
  public class GameController : Controller
  {
    private Match _match;
    private bool _progress;
    private User _first;
    private User _second;

    public GameController(TicTacToe main, User first, User second) : base(main)
    {
      Main = main;
      _match = new Match(this, first, second);
      _first = first;
      _second = second;
      _progress = true;
    }

    public bool Turn(int index)
    {
      return _progress ? _match.Turn(index) : false;
    }

    public bool InProgress(int index)
    {
      _progress = !_match.InColumn(index) && !_match.InRow(index) && !_match.InDiagonal();
      return _progress;
    }

    public Symbol CurrentTurn()
    {
      return _match.GetCurrent();
    }
  }
}