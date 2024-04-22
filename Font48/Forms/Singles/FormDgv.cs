using Font48.Classes;
using Font48.Models.Controls;
using Font48Core.Classes;
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
  public partial class FormDgv : FormBaseLog
  {
    public FormDgv() : base()
    {
      InitializeComponent();
    }
    public FormDgv(ClassBL.AppTypeEnum appType) : base(appType)
    {
      InitializeComponent();
      List<ClassData> list = new List<ClassData>();
      list.Add( new ClassData { Name="Swapnil",Description="Dev"});
      list.Add(new ClassData { Name = "Tahmid", Description = "Dev" });
      dataGridView1.DataSource = list;
    }

    private void FormDgv_Load(object sender, EventArgs e)
    {
      int k = 1;
    }
  }
}
