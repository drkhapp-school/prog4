namespace tictactoe
{
  public class GameController
  {
    private TicTacToe _main;
    private Match _match;
    private User _first;
    private User _second;

    public GameController(TicTacToe main, User first, User second)
    {
      _main = main;
      _match = new Match(this, first, second);
      _first = first;
      _second = second;
    }

    public void Turn(int index) {
      // Ask game to handle turn
      if (_match.Turn(index)) {
        // Cell was changed, notify controller
        _main.AddCell(this, index, _match.GetCurrent());

        // Ask game to check for victors
        if (_match.Victory()) {
          // Victory claimed, notify controller
          _main.Victory(this);
        }
      } else {
        // Notify controller of an invalid move.
        _main.Notify(this, "Invalid action.");
      }
    }
  }
}