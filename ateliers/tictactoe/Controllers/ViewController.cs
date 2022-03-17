using System;
using System.Windows.Forms;
using tictactoe.Models;
using tictactoe.Views;

namespace tictactoe
{
  public class ViewController : Controller
  {
    private FormMatch _form;

    public ViewController(TicTacToe main) : base(main)
    {
      Main = main;
      _form = new FormMatch(this);
      _form.Show();
    }

    public void Turn(int cell)
    {
      Main.Turn(this, cell);
    }

    public void DrawCell(int cell, Symbol symbol)
    {
      _form.DrawCell(cell, symbol);
    }

    public void EndMatch()
    {
      _form.Close();
      Main.EndMatch(this);
    }

    public void Victory()
    {
      MessageBox.Show("YOU WON BITCH");
    }

    public void Stalemate()
    {
      MessageBox.Show("TIE DUMBASS");
    }
  }
}