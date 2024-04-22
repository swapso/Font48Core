namespace Font48.Forms
{
  partial class Options
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
      this.btnApply = new System.Windows.Forms.Button();
      this.label24 = new System.Windows.Forms.Label();
      this.comboBoxFontSize = new System.Windows.Forms.ComboBox();
      this.SuspendLayout();
      // 
      // btnApply
      // 
      this.btnApply.Location = new System.Drawing.Point(327, 51);
      this.btnApply.Name = "btnApply";
      this.btnApply.Size = new System.Drawing.Size(97, 40);
      this.btnApply.TabIndex = 8;
      this.btnApply.Text = "OK";
      this.btnApply.UseVisualStyleBackColor = true;
      this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
      // 
      // label24
      // 
      this.label24.AutoSize = true;
      this.label24.Location = new System.Drawing.Point(117, 61);
      this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label24.Name = "label24";
      this.label24.Size = new System.Drawing.Size(77, 20);
      this.label24.TabIndex = 31;
      this.label24.Text = "Font Size";
      // 
      // comboBoxFontSize
      // 
      this.comboBoxFontSize.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.comboBoxFontSize.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.comboBoxFontSize.FormattingEnabled = true;
      this.comboBoxFontSize.Items.AddRange(new object[] {
            "8.25",
            "9",
            "9.75",
            "11.25",
            "12",
            "14.25",
            "15.75"});
      this.comboBoxFontSize.Location = new System.Drawing.Point(203, 58);
      this.comboBoxFontSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.comboBoxFontSize.MaxDropDownItems = 45;
      this.comboBoxFontSize.Name = "comboBoxFontSize";
      this.comboBoxFontSize.Size = new System.Drawing.Size(80, 28);
      this.comboBoxFontSize.TabIndex = 30;
      // 
      // Options
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(570, 191);
      this.Controls.Add(this.label24);
      this.Controls.Add(this.comboBoxFontSize);
      this.Controls.Add(this.btnApply);
      this.Name = "Options";
      this.Text = "Options";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Button btnApply;
    internal System.Windows.Forms.Label label24;
    internal System.Windows.Forms.ComboBox comboBoxFontSize;
  }
}