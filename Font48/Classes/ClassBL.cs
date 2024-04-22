using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Font48.Classes
{
  public class ClassBL
  {
    public enum ControlTypeEnum
    {
      Form = 0,
      Label = 1,
      TextBox = 2,
      Button = 3,
      ComboBox = 4,
    }
    public enum ActionTypeEnum
    {
      Load = 1,
      Shown = 2,
      FontChanged = 3,
    }
    public enum AppTypeEnum
    {
      Net48 = 1,
      NetCore = 2,
    }
  }
}
