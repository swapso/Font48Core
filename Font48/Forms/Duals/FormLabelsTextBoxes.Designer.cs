namespace Font48.Forms.Duals
{
  partial class FormLabelsTextBoxes
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
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(200, 0);
      this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(42, 13);
      this.label2.TabIndex = 9;
      this.label2.Text = "Label 2";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(0, 0);
      this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(42, 13);
      this.label1.TabIndex = 8;
      this.label1.Text = "Label 1";
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(100, 0);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(100, 20);
      this.textBox1.TabIndex = 10;
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(300, 0);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(100, 20);
      this.textBox2.TabIndex = 11;
      // 
      // FormLabelsTextBoxes
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(533, 292);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.label1);
      this.Name = "FormLabelsTextBoxes";
      this.Text = "FormLabelsTextBoxes";
      this.Controls.SetChildIndex(this.label1, 0);
      this.Controls.SetChildIndex(this.textBox1, 0);
      this.Controls.SetChildIndex(this.label2, 0);
      this.Controls.SetChildIndex(this.textBox2, 0);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
  }
}