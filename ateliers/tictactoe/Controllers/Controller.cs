namespace tictactoe
{
  public abstract class Controller
  {
    private TicTacToe _main;

    protected Controller(TicTacToe main)
    {
      _main = main;
    }

    protected TicTacToe Main
    {
      get => _main;
      set => _main = value;
    }
  }
}