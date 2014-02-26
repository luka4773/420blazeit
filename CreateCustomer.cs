using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        private void CreateCustomerButton_Click(object sender, EventArgs e)
        {
            String connectionString =
                @"server=(LocalDB)\v11.0;AttachDbFilename=""D:\ConstructionSemester2\CarRentalCustomerGUIDesign\CarRentalCustomerGUIDesign\Database1.mdf""";
            using (SqlConnection connection = new SqlConnection(
                connectionString))
            {
                string queryString =
                    "INSERT INTO [Table] (Firstname, Lastname, Age, CPR) VALUES (@Firstname, @Lastname, @Age, @CPR)";
                SqlCommand command = new SqlCommand(queryString, connection);

                command.Parameters.AddWithValue("@Firstname", FirstName.Text);
                command.Parameters.AddWithValue("@Lastname", LastName.Text);
                command.Parameters.AddWithValue("@Age", Age.Text);
                command.Parameters.AddWithValue("@CPR", CPRNumber.Text);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
