using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
  public enum SampleEnum
  {
    [Description("a    bc")]
    abc ,

    [Description("efff gggg")]
    efg ,

    [Description("h   i j")]
    hij 

  }
}
