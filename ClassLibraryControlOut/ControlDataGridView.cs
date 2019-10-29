using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ClassLibraryControlOut
{
    public partial class ControlDataGridView : UserControl
    {
        public ControlDataGridView()
        {
            InitializeComponent();
        }

        public void LoadEnumeration(Type type)
        {
            foreach (var elem in Enum.GetValues(type))
            {
                dataGridView.Rows.Add(elem.ToString());
            }
        }
    }
}
