using System;
using tictactoe.Models;
using tictactoe.Views;

namespace tictactoe
{
  public class ViewController : Controller
  {
    private FormMatch _form;
    public ViewController(TicTacToe main) : base (main)
    {
      Main = main;
      _form = new FormMatch(this);
      _form.Show();
    }

    public void DrawCell(int cell, Symbol symbol)
    {
      throw new NotImplementedException();
    }

    public void EndMatch()
    {
      Main.EndMatch(this);
      _form.Close();
    }
  }
}