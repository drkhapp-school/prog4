namespace tictactoe
{
  partial class FormMenu
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

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
      this.BtnStart = new System.Windows.Forms.Button();
      this.BtnQuit = new System.Windows.Forms.Button();
      this.LabTitle = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // BtnStart
      // 
      this.BtnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
      this.BtnStart.BackColor = System.Drawing.Color.White;
      this.BtnStart.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BtnStart.ForeColor = System.Drawing.Color.Black;
      this.BtnStart.Location = new System.Drawing.Point(12, 202);
      this.BtnStart.MaximumSize = new System.Drawing.Size(277, 64);
      this.BtnStart.Name = "BtnStart";
      this.BtnStart.Size = new System.Drawing.Size(277, 64);
      this.BtnStart.TabIndex = 0;
      this.BtnStart.Text = "let\'s go";
      this.BtnStart.UseVisualStyleBackColor = false;
      this.BtnStart.Click += new System.EventHandler(this.BtnStartClick);
      // 
      // BtnQuit
      // 
      this.BtnQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
      this.BtnQuit.BackColor = System.Drawing.Color.White;
      this.BtnQuit.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BtnQuit.ForeColor = System.Drawing.Color.Black;
      this.BtnQuit.Location = new System.Drawing.Point(12, 272);
      this.BtnQuit.MaximumSize = new System.Drawing.Size(277, 64);
      this.BtnQuit.Name = "BtnQuit";
      this.BtnQuit.Size = new System.Drawing.Size(277, 64);
      this.BtnQuit.TabIndex = 1;
      this.BtnQuit.Text = "nah";
      this.BtnQuit.UseVisualStyleBackColor = false;
      this.BtnQuit.Click += new System.EventHandler(this.BtnQuitClick);
      // 
      // LabTitle
      // 
      this.LabTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.LabTitle.ForeColor = System.Drawing.SystemColors.Control;
      this.LabTitle.Location = new System.Drawing.Point(12, 61);
      this.LabTitle.MaximumSize = new System.Drawing.Size(276, 108);
      this.LabTitle.Name = "LabTitle";
      this.LabTitle.Size = new System.Drawing.Size(276, 108);
      this.LabTitle.TabIndex = 2;
      this.LabTitle.Text = "tic tac toe baby";
      this.LabTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // FormMenu
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 45F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.BackColor = System.Drawing.Color.SlateBlue;
      this.ClientSize = new System.Drawing.Size(301, 477);
      this.Controls.Add(this.LabTitle);
      this.Controls.Add(this.BtnQuit);
      this.Controls.Add(this.BtnStart);
      this.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
      this.Name = "FormMenu";
      this.Text = "FormMenu";
      this.ResumeLayout(false);

    }

    private System.Windows.Forms.Label LabTitle;

    private System.Windows.Forms.Button BtnQuit;

    private System.Windows.Forms.Button BtnStart;

    #endregion
  }
}