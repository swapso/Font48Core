namespace Font48.Forms
{
  partial class FormContainer
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
      tabControl1 = new System.Windows.Forms.TabControl();
      tabPage1 = new System.Windows.Forms.TabPage();
      tabPage2 = new System.Windows.Forms.TabPage();
      button1 = new System.Windows.Forms.Button();
      tabControl1.SuspendLayout();
      tabPage1.SuspendLayout();
      SuspendLayout();
      // 
      // tabControl1
      // 
      tabControl1.Controls.Add(tabPage1);
      tabControl1.Controls.Add(tabPage2);
      tabControl1.Location = new System.Drawing.Point(3, 1);
      tabControl1.Name = "tabControl1";
      tabControl1.SelectedIndex = 0;
      tabControl1.Size = new System.Drawing.Size(761, 403);
      tabControl1.TabIndex = 10;
      // 
      // tabPage1
      // 
      tabPage1.Controls.Add(button1);
      tabPage1.Location = new System.Drawing.Point(4, 34);
      tabPage1.Name = "tabPage1";
      tabPage1.Padding = new System.Windows.Forms.Padding(3);
      tabPage1.Size = new System.Drawing.Size(753, 365);
      tabPage1.TabIndex = 0;
      tabPage1.Text = "tabPage1";
      tabPage1.UseVisualStyleBackColor = true;
      // 
      // tabPage2
      // 
      tabPage2.Location = new System.Drawing.Point(4, 34);
      tabPage2.Name = "tabPage2";
      tabPage2.Padding = new System.Windows.Forms.Padding(3);
      tabPage2.Size = new System.Drawing.Size(292, 112);
      tabPage2.TabIndex = 1;
      tabPage2.Text = "tabPage2";
      tabPage2.UseVisualStyleBackColor = true;
      // 
      // button1
      // 
      button1.Location = new System.Drawing.Point(22, 37);
      button1.Name = "button1";
      button1.Size = new System.Drawing.Size(112, 34);
      button1.TabIndex = 0;
      button1.Text = "button1";
      button1.UseVisualStyleBackColor = true;
      button1.Click += button1_Click;
      // 
      // FormContainer
      // 
      AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
      AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      ClientSize = new System.Drawing.Size(1333, 865);
      Controls.Add(tabControl1);
      Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
      Name = "FormContainer";
      Text = "FormContainer";
      Controls.SetChildIndex(tabControl1, 0);
      tabControl1.ResumeLayout(false);
      tabPage1.ResumeLayout(false);
      ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TabPage tabPage2;
  }
}