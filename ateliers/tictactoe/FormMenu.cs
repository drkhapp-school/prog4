using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
  public partial class FormMenu : Form
  {
    private ViewController _controller;

    public FormMenu(ViewController controller)
    {
      _controller = controller;
      InitializeComponent();
    }
    private void BtnStartClick(object sender, EventArgs e)
    {
      throw new System.NotImplementedException();
    }

    private void BtnQuitClick(object sender, EventArgs e)
    {
      throw new System.NotImplementedException();
    }
  }
}
