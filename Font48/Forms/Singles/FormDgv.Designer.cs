namespace Font48.Forms
{
  partial class FormDgv
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
      components = new System.ComponentModel.Container();
      dataGridView1 = new System.Windows.Forms.DataGridView();
      nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      classDataBindingSource = new System.Windows.Forms.BindingSource(components);
      ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
      ((System.ComponentModel.ISupportInitialize)classDataBindingSource).BeginInit();
      SuspendLayout();
      // 
      // dataGridView1
      // 
      dataGridView1.AllowUserToAddRows = false;
      dataGridView1.AllowUserToDeleteRows = false;
      dataGridView1.AutoGenerateColumns = false;
      dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
      dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
      dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { nameDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn });
      dataGridView1.DataSource = classDataBindingSource;
      dataGridView1.Location = new System.Drawing.Point(3, 3);
      dataGridView1.Name = "dataGridView1";
      dataGridView1.ReadOnly = true;
      dataGridView1.Size = new System.Drawing.Size(240, 150);
      dataGridView1.TabIndex = 10;
      // 
      // nameDataGridViewTextBoxColumn
      // 
      nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
      nameDataGridViewTextBoxColumn.HeaderText = "Name";
      nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
      nameDataGridViewTextBoxColumn.ReadOnly = true;
      nameDataGridViewTextBoxColumn.Width = 64;
      // 
      // descriptionDataGridViewTextBoxColumn
      // 
      descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
      descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
      descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
      descriptionDataGridViewTextBoxColumn.ReadOnly = true;
      descriptionDataGridViewTextBoxColumn.Width = 92;
      // 
      // classDataBindingSource
      // 
      classDataBindingSource.DataSource = typeof(Font48Core.Classes.ClassData);
      // 
      // FormDgv
      // 
      AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      ClientSize = new System.Drawing.Size(622, 337);
      Controls.Add(dataGridView1);
      Name = "FormDgv";
      Text = "FormDgv";
      Load += FormDgv_Load;
      Controls.SetChildIndex(dataGridView1, 0);
      ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
      ((System.ComponentModel.ISupportInitialize)classDataBindingSource).EndInit();
      ResumeLayout(false);
    }

    #endregion

    public System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    private System.Windows.Forms.BindingSource classDataBindingSource;
  }
}