using tictactoe.Models;

namespace tictactoe.Controllers
{
  public class GameController : Controller
  {
    private Match _match;
    private User _first;
    private User _second;

    public GameController(TicTacToe main, User first, User second): base(main)
    {
      Main = main;
      _match = new Match(this, first, second);
      _first = first;
      _second = second;
    }

    public void Turn(int index) {
      // Ask game to handle turn
      if (_match.Turn(index)) {
        // Cell was changed, notify controller
        Main.AddCell(this, index, _match.GetCurrent());

        // Ask game to check for victors
        if (_match.Victory()) {
          // Victory claimed, notify controller
          Main.Victory(this);
        }
      } else {
        // Notify controller of an invalid move.
        Main.Notify(this, "Invalid action.");
      }
    }
  }
}