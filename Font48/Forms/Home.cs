using Font48.Classes;
using Font48.Forms.Duals;
using Font48.Forms.Singles;
using Font48.Models.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.Versioning;
using System.Windows.Forms;

namespace Font48.Forms
{
  [SupportedOSPlatform("windows")]
  public partial class Home : Form
  {
    private ClassBL.AppTypeEnum _appType;

    public Home(Classes.ClassBL.AppTypeEnum appType)
    {
      InitializeComponent();
      _appType = appType;

    }

    private void labelsToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      FormLabels f = new FormLabels(_appType);
      f.MdiParent = this;
      f.Show();
    }

    private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      float curFontSize = this.Font.Size;
      Options f = new Options(curFontSize);

      f.ShowDialog();
      if (f.DialogResult == DialogResult.OK)
      {
        this.Text = "Home " + f.CurFontSize.ToString();
        Font curFont = this.Font;
        Font newFont = new Font(curFont.FontFamily, f.CurFontSize);
        this.Font = newFont;
      }
    }

    private void textboxesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FormTextboxes f = new FormTextboxes(_appType);
      f.MdiParent = this;
      f.Show();
    }

    private void buttonsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FormButtons f = new FormButtons(_appType);
      f.MdiParent = this;
      f.Show();
    }

    private void labelsTextBoxesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      var f = new FormLabelsTextBoxes(_appType);
      f.MdiParent = this;
      f.Show();
    }

    private void textBoxesButtonsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      var f = new FormTextBoxesButtons(_appType);
      f.MdiParent = this;
      f.Show();
    }

    private void labelsCoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      var f = new FormLabelsComboBoxes(_appType);
      f.MdiParent = this;
      f.Show();
    }

    private void comboboxesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      var f = new FormComboBoxes(_appType);
      f.MdiParent = this;
      f.Show();
    }

    private void dataGridViewsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      var f = new FormDgv(_appType);
      f.MdiParent = this;
      f.Show();

    }

    private void containersToolStripMenuItem_Click(object sender, EventArgs e)
    {
      var f = new FormContainer(_appType);
      f.MdiParent = this;
      f.Show();
    }
  }
}
