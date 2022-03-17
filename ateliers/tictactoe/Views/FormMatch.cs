using System.Drawing;
using System.Windows.Forms;
using tictactoe.Models;
using tictactoe.Properties;

namespace tictactoe.Views
{
  public partial class FormMatch : Form
  {
    private ViewController _controller;

    public FormMatch(ViewController controller)
    {
      _controller = controller;
      InitializeComponent();
    }

    private void BtnQuit_Click(object sender, System.EventArgs e)
    {
      _controller.EndMatch();
    }

    private void label2_Click(object sender, System.EventArgs e)
    {
    }

    private void Grid_Click(object sender, System.EventArgs e)
    {
      var props = (MouseEventArgs) e;
      var image = (PictureBox) sender;
      var x = props.X;
      var y = props.Y;

      _controller.Turn(x / (image.Width / 3) + y / (image.Height / 3) * image.Width / (image.Width / 3));
    }

    public void DrawCell(int cell, Symbol symbol)
    {
      var drawing = symbol == Symbol.X ? Resources.x : Resources.o;
      drawing = new Bitmap(drawing, new Size(90, 90));
      Grid.CreateGraphics().DrawImage(drawing, cell % 3 * 100 + 5, cell / 3 * 100 + 5);
    }
  }
}