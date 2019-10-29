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
        
        public void LoadData(Type type)
        {
            dataGridView.Rows.Clear();
            foreach (var elem in Enum.GetValues(type))
            {
                dataGridView.Rows.Add();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadData(typeof(Type));
        }
    }
}
