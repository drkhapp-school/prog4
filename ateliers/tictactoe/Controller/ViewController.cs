using System;

namespace tictactoe
{
  public class ViewController
  {
    private TicTacToe _main;

    public ViewController(TicTacToe main)
    {
      _main = main;
    }

    internal void DrawCell(int cell, Symbol symbol)
    {
      throw new NotImplementedException();
    }
  }
}