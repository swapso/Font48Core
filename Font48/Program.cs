using Font48.Classes;
using Font48.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Font48
{
  internal static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [SupportedOSPlatform("windows")]
    [STAThread]
    static void Main()
    {
      var appType = ClassBL.AppTypeEnum.NetCore;
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new Home(appType));
    }
  }
}
