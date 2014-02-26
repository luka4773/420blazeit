namespace CarRentalCustomerGUIDesign
{
    partial class DisplayCustomers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CustomerListCloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CustomerListCloseButton
            // 
            this.CustomerListCloseButton.Location = new System.Drawing.Point(12, 186);
            this.CustomerListCloseButton.Name = "CustomerListCloseButton";
            this.CustomerListCloseButton.Size = new System.Drawing.Size(75, 23);
            this.CustomerListCloseButton.TabIndex = 0;
            this.CustomerListCloseButton.Text = "Close";
            this.CustomerListCloseButton.UseVisualStyleBackColor = true;
            this.CustomerListCloseButton.Click += new System.EventHandler(this.CustomerListCloseButton_Click);
            // 
            // DisplayCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 233);
            this.Controls.Add(this.CustomerListCloseButton);
            this.Name = "DisplayCustomers";
            this.Text = "Displaying Customers";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CustomerListCloseButton;
    }
}