using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
  public partial class EnumStringValue : Form
  {
    public EnumStringValue()
    {
      InitializeComponent();
      
      listBox1.DataSource = SampleEnumExtensions.GetKeyValuePair();
      listBox1.ValueMember = "Key";
      listBox1.DisplayMember = "Value";
      
      checkedListBox1.DataSource = SampleEnumExtensions.GetKeyValuePair();
      checkedListBox1.ValueMember = "Key";
      checkedListBox1.DisplayMember = "Value";
    }
  }
}
