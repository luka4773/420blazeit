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
    public partial class CreateCustomer : Form
    {
        public CreateCustomer()
        {
            InitializeComponent();
            
        }

        private void LabelCPR_Click(object sender, EventArgs e)
        {

        }

        private void FormClose_Click(object sender, EventArgs e)
        {
          ActiveForm.Close();
        }
    }
}
