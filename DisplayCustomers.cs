using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalCustomerGUIDesign
{
    public partial class DisplayCustomers : Form
    {
        public DisplayCustomers()
        {
            InitializeComponent();
        }

        private void CustomerListCloseButton_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void DisplayCustomers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customerDataDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.customerDataDataSet.Table);

        }
    }
}
