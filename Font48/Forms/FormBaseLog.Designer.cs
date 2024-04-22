namespace Font48.Forms
{
  partial class FormBaseLog
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
      this.btnLogData = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnLogData
      // 
      this.btnLogData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnLogData.Location = new System.Drawing.Point(699, 398);
      this.btnLogData.Name = "btnLogData";
      this.btnLogData.Size = new System.Drawing.Size(89, 40);
      this.btnLogData.TabIndex = 9;
      this.btnLogData.Tag = "Ignore";
      this.btnLogData.Text = "Log Data";
      this.btnLogData.UseVisualStyleBackColor = true;
      // 
      // FormBaseLog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.btnLogData);
      this.Name = "FormBaseLog";
      this.Text = "FormBaseLog";
      this.Load += new System.EventHandler(this.FormBaseLog_Load);
      this.Shown += new System.EventHandler(this.FormBaseLog_Shown);
      this.FontChanged += new System.EventHandler(this.FormBaseLog_FontChanged);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnLogData;
  }
}