using Font48.Classes;
using Font48.Models.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Font48.Forms
{
  [SupportedOSPlatform("windows")]
  public partial class FormBaseLog : Form
  {
    private ClassBL.AppTypeEnum _appType;
    private ModelControls _model;
    private TbTest _tbTest;
    private TbAction _tbAction;
    public FormBaseLog()
    {
      InitializeComponent();
    }
    public FormBaseLog(ClassBL.AppTypeEnum appType)
    {
      InitializeComponent();
      _appType = appType;
      if (this.DesignMode) return;
      _model = new ModelControls();
    }

    private void RecordTestInfo()
    {
      _tbTest = new TbTest();
      _tbTest.TestName = this.Text;
      _tbTest.Created = DateTime.Now;

      StringBuilder sb = new StringBuilder();

      foreach (Control c in this.Controls)
      {
        if (c.Tag != null && c.Tag.ToString().ToLower() == "ignore") continue;
        sb.Append(c.ToString()).Append(" - ");
        //tbControl.ControlName = c.Name;
        //tbControl.ControlText = c.Text;
        //tbControl.ControlType = c.GetType().ToString();
        //tbControl.LocationX = c.Location.X;
        //tbControl.LocationY = c.Location.Y;
        //tbControl.SizeX = c.Size.Width;
        //tbControl.SizeY = c.Size.Height;
        //tbControl.IsAutoSize = c.AutoSize;

      }
      _tbTest.Description = sb.ToString();
      _tbTest.FontSize = (decimal?)this.Font.Size;
      _tbTest.AppTypeId = (int)_appType;

      _model.TbTests.Add(_tbTest);
      _model.SaveChanges();

    }

    private void RecordControlInfo()
    {

      List<TbControl> tbControlsList = new List<TbControl>();

      int actionId = _tbAction.Id;
      foreach (Control c in this.Controls)
      {
        if (c.Tag != null && c.Tag.ToString().ToLower() == "ignore") continue;
        TbControl ctl = new TbControl();
        ctl.ControlName = c.Name;
        //ctl.ControlText = c.Text;
        ctl.ControlTypeId = GetControlTypeId(c.GetType().Name);
        ctl.LocationX = c.Location.X;
        ctl.LocationY = c.Location.Y;
        ctl.SizeX = c.Size.Width;
        ctl.SizeY = c.Size.Height;
        ctl.IsAutoSize = c.AutoSize;

        ctl.ActionId = actionId;

        tbControlsList.Add(ctl);
      }
      _model.TbControls.AddRange(tbControlsList);
      _model.SaveChanges();

    }

    private int? GetControlTypeId(string name)
    {
      if (!string.IsNullOrEmpty(name))
      {
        if (Enum.TryParse(name, out ClassBL.ControlTypeEnum enumValue))
        {
          return (int)enumValue;
        }
      }
      return null;
    }

    private void RecordActionInfo(ClassBL.ActionTypeEnum actionType)
    {
      _tbAction = new TbAction();
      _tbAction.TestId = _tbTest.Id;
      _tbAction.ActionTypeId = (int)actionType;
      _tbAction.Created = DateTime.Now;
      _tbAction.FontSize = this.Font.Size;
      _tbAction.FontName = this.Font.Name;


      _model.TbActions.Add(_tbAction);
      _model.SaveChanges();

    }

    private void FormBaseLog_Load(object sender, EventArgs e)
    {
      if (this.DesignMode) return;

      RecordTestInfo();
      RecordInfo(ClassBL.ActionTypeEnum.Load);

    }

    protected void RecordInfo(ClassBL.ActionTypeEnum actionType)
    {

      RecordActionInfo(actionType);
      RecordForm();// actionType);
      RecordControlInfo();
    }

    private void FormBaseLog_Shown(object sender, EventArgs e)
    {
      if (this.DesignMode) return;

      RecordInfo(ClassBL.ActionTypeEnum.Shown);

      int numControls = this.Controls.Count;
      var lastControl = this.Controls[numControls - 1];
      lastControl.FontChanged += new System.EventHandler(this.lastControl_FontChanged);

    }
    private void FormBaseLog_FontChanged(object sender, EventArgs e)
    {
      if (this.DesignMode) return;


      //RecordInfo(ClassBL.ActionTypeEnum.FontChanged);
    }

    private void RecordForm()//ClassBL.ActionTypeEnum actionType)
    {
      TbControl ctl = new TbControl();
      ctl.ControlName = this.Name;
      //ctl.ControlText = c.Text;
      ctl.ControlTypeId = (int)ClassBL.ControlTypeEnum.Form; // GetControlTypeId(this.GetType().Name);
      ctl.LocationX = this.Location.X;
      ctl.LocationY = this.Location.Y;
      ctl.SizeX = this.Size.Width;
      ctl.SizeY = this.Size.Height;
      ctl.IsAutoSize = this.AutoSize;

      ctl.ActionId = _tbAction.Id;// (int)actionType;

      _model.TbControls.Add(ctl);
      _model.SaveChanges();
    }

    private void lastControl_FontChanged(object sender, EventArgs e)
    {
      RecordInfo(ClassBL.ActionTypeEnum.FontChanged);
    }


  }
}
