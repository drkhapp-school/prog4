using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using tictactoe.Models;
using tictactoe.Views;

namespace tictactoe
{
  public class TicTacToe
  {
    private FormMenu _menu;
    private List<GameController> _gameControllers;
    private List<ViewController> _viewControllers;

    public TicTacToe()
    {
      _gameControllers = new List<GameController>();
      _viewControllers = new List<ViewController>();
      
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      
      _menu = new FormMenu(this);
      
      Application.Run(_menu);
    }

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    public static void Main()
    {
      new TicTacToe();
    }

    public void Turn(ViewController instance, int cell)
    {
      var index = _viewControllers.IndexOf(instance);
      _gameControllers[index].Turn(cell);
    }

    public void Turn(GameController instance, int cell, Symbol symbol)
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

    public void EndMatch(ViewController instance)
    {
      var index = _viewControllers.IndexOf(instance);
      _gameControllers.RemoveAt(index);
      _viewControllers.RemoveAt(index);
    }
  }
}
