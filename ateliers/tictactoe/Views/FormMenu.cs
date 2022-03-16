using System;
using System.Windows.Forms;
using tictactoe.Controllers;

namespace tictactoe.Views
{
  public partial class FormMenu : Form
  {
    private TicTacToe _main;

    public FormMenu(TicTacToe main)
    {
      _main = main;
      InitializeComponent();
    }

    private void BtnStartClick(object sender, EventArgs e)
    {
        _main.StartMatch();
    }

    private void BtnQuitClick(object sender, EventArgs e)
    {
      for (int i = 0; i < 254; i++)
      {
        _main.StartMatch();
      }
    }
  }
}