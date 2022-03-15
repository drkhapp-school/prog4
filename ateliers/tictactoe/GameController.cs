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
  }
}