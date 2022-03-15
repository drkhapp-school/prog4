using System.ComponentModel;

namespace tictactoe
{
  partial class FormMatch
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }

      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMatch));
      this.LabTitle = new System.Windows.Forms.Label();
      this.BtnQuit = new System.Windows.Forms.Button();
      this.ImgBack = new System.Windows.Forms.PictureBox();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize) (this.ImgBack)).BeginInit();
      ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // LabTitle
      // 
      this.LabTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.LabTitle.ForeColor = System.Drawing.SystemColors.Control;
      this.LabTitle.Location = new System.Drawing.Point(8, 8);
      this.LabTitle.MinimumSize = new System.Drawing.Size(276, 108);
      this.LabTitle.Name = "LabTitle";
      this.LabTitle.Size = new System.Drawing.Size(770, 108);
      this.LabTitle.TabIndex = 3;
      this.LabTitle.Text = "tic tac toe baby";
      this.LabTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // BtnQuit
      // 
      this.BtnQuit.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
      this.BtnQuit.BackColor = System.Drawing.Color.White;
      this.BtnQuit.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
      this.BtnQuit.ForeColor = System.Drawing.Color.Black;
      this.BtnQuit.Location = new System.Drawing.Point(496, 744);
      this.BtnQuit.MaximumSize = new System.Drawing.Size(277, 64);
      this.BtnQuit.Name = "BtnQuit";
      this.BtnQuit.Size = new System.Drawing.Size(277, 64);
      this.BtnQuit.TabIndex = 5;
      this.BtnQuit.Text = "nah";
      this.BtnQuit.UseVisualStyleBackColor = false;
      this.BtnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
      // 
      // ImgBack
      // 
      this.ImgBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.ImgBack.Image = ((System.Drawing.Image) (resources.GetObject("ImgBack.Image")));
      this.ImgBack.Location = new System.Drawing.Point(94, 119);
      this.ImgBack.Name = "ImgBack";
      this.ImgBack.Size = new System.Drawing.Size(600, 600);
      this.ImgBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.ImgBack.TabIndex = 4;
      this.ImgBack.TabStop = false;
      this.ImgBack.Click += new System.EventHandler(this.pictureBox1_Click);
      // 
      // pictureBox1
      // 
      this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
      this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(200, 300);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(300, 300);
      this.pictureBox1.TabIndex = 6;
      this.pictureBox1.TabStop = false;
      // 
      // FormMatch
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 45F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.SlateBlue;
      this.ClientSize = new System.Drawing.Size(784, 821);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.BtnQuit);
      this.Controls.Add(this.LabTitle);
      this.Controls.Add(this.ImgBack);
      this.DoubleBuffered = true;
      this.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold);
      this.Margin = new System.Windows.Forms.Padding(10);
      this.Name = "FormMatch";
      this.Text = "FormMatch";
      ((System.ComponentModel.ISupportInitialize) (this.ImgBack)).EndInit();
      ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Label LabTitle;
    private System.Windows.Forms.Button BtnQuit;
    private System.Windows.Forms.PictureBox ImgBack;
    private System.Windows.Forms.PictureBox pictureBox1;
  }
}