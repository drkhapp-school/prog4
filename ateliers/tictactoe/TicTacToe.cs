using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
  public class TicTacToe
  {
    private List<GameController> _gameControllers;
    private List<ViewController> _viewControllers;

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    public static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new FormMatch(new ViewController(new TicTacToe())));
    }

    public void AddCell(GameController instance, int cell, Symbol symbol)
    {
      var index = _gameControllers.IndexOf(instance);
      _viewControllers[index].DrawCell(cell, symbol);
    }

    public void Victory(GameController gameController)
    {
      throw new NotImplementedException();
    }

    public void Notify(GameController gameController, string v)
    {
      throw new NotImplementedException();
    }

    public void StartMatch()
    {
      // Get two players
      var first = new User("Name");
      var second = new User("Cool");

      // Initialize controllers
      _gameControllers.Add(new GameController(this, first, second));
      _viewControllers.Add(new ViewController(this));
    }
  }
}