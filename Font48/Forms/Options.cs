using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Font48.Forms
{
  public partial class Options : Form
  {
    private float _curFontSize;

    public Options(float curFontSize)
    {
      InitializeComponent();
      _curFontSize = curFontSize;
    }

    public float CurFontSize { get => _curFontSize; set => _curFontSize = value; }

    //  FillCombobox();
    //}

    //private void FillCombobox()
    //{
    //  comboBox1.Items.Add(9);
    //  comboBox1.Items.Add(11);
    //  comboBox1.Items.Add(14);
    //  comboBox1.Items.Add(15);
    //}
    private void btnApply_Click(object sender, EventArgs e)
    {
      _curFontSize =  Convert.ToSingle(comboBoxFontSize.SelectedItem.ToString());
      this.DialogResult = DialogResult.OK;
      this.Close();
    }
  }
}
