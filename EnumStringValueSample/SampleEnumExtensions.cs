using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace WindowsFormsApp1
{
  public static class SampleEnumExtensions
  {
    public static string ToStringDescription(this SampleEnum val)
    {
      var attributes = (DescriptionAttribute[])val.GetType().GetField(val.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false);
      return attributes.Length > 0 ? attributes[0].Description : string.Empty;
    }

    public static List<KeyValuePair<SampleEnum, string>> GetKeyValuePair()
    {
      return Enum.GetValues(typeof(SampleEnum)).OfType<SampleEnum>().Select(x =>
           new KeyValuePair<SampleEnum, string>
           (
              x,
              x.ToStringDescription()
           )
            ).ToList();
    }
  }
}