namespace Font48.Forms
{
  partial class FormLabels
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
      label2 = new System.Windows.Forms.Label();
      label1 = new System.Windows.Forms.Label();
      SuspendLayout();
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Location = new System.Drawing.Point(100, 0);
      label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      label2.Name = "label2";
      label2.Size = new System.Drawing.Size(44, 15);
      label2.TabIndex = 7;
      label2.Text = "Label 2";
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new System.Drawing.Point(0, 0);
      label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      label1.Name = "label1";
      label1.Size = new System.Drawing.Size(44, 15);
      label1.TabIndex = 5;
      label1.Text = "Label 1";
      // 
      // FormLabels
      // 
      AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      ClientSize = new System.Drawing.Size(622, 337);
      Controls.Add(label1);
      Controls.Add(label2);
      Name = "FormLabels";
      Text = "FormLabels";
      Controls.SetChildIndex(label2, 0);
      Controls.SetChildIndex(label1, 0);
      this.Load += new System.EventHandler(this.FormLabels_Load);
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    public System.Windows.Forms.Label label2;
    public System.Windows.Forms.Label label1;
  }
}