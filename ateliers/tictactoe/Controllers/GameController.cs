using tictactoe.Models;

namespace tictactoe
{
  public enum Status
  {
    Ongoing,
    Stalemate,
    Ended
  }

  public class GameController : Controller
  {
    private Match _match;
    private Status _status;
    private User _first;
    private User _second;

    public GameController(TicTacToe main, User first, User second) : base(main)
    {
      Main = main;
      _match = new Match(this);
      _status = Status.Ongoing;
      _first = first;
      _second = second;
    }

    public Status Status => _status;

    public bool Turn(int index)
    {
      // Return false if the game is over
      if (_status != Status.Ongoing) return false;
      // Run move, return false if it's invalid
      if (!_match.Turn(index)) return false;

      // Checks
      CheckStalemate();
      CheckVictory(index);
      return true;
    }

    public void CheckStalemate()
    {
      if (_status == Status.Ongoing && _match.FullGrid())
        _status = Status.Stalemate;
    }

    public void CheckVictory(int index)
    {
      if (_status == Status.Ongoing && _match.InRow(index) && _match.InColumn(index) && _match.InDiagonal())
        _status = Status.Ended;
    }

    public Symbol CurrentTurn()
    {
      return _match.Current;
    }
  }
}