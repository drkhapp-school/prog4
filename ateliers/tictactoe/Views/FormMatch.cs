using System.Windows.Forms;
using tictactoe.Controllers;

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

    private void pictureBox1_Click(object sender, System.EventArgs e)
    {

    }

    private void BtnQuit_Click(object sender, System.EventArgs e)
    {
      _controller.EndMatch();
    }

    private void label2_Click(object sender, System.EventArgs e)
    {

    }
  }
}