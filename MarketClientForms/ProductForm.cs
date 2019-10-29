using ClassLibraryControlSelected;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketClientForms
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
            controlComboListBox.LoadEnumeration(typeof(TestEnum));
        }

        private void controlComboBoxSelected_ComboBoxSelectedElementChange(object sender, EventArgs e)
        {
            MessageBox.Show(controlComboListBox.SelectedText);
        }
        private void buttonChange_Click(object sender, EventArgs e)
        {
            controlComboListBox.SelectedIndex = 0;
        }
    }
}
