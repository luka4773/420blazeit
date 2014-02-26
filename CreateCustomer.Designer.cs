namespace CarRentalCustomerGUIDesign
{
    partial class CreateCustomer
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
            this.LastName = new System.Windows.Forms.TextBox();
            this.CPRNumber = new System.Windows.Forms.TextBox();
            this.Age = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.CreateCustomerButton = new System.Windows.Forms.Button();
            this.LabelFirstName = new System.Windows.Forms.Label();
            this.LabelLastName = new System.Windows.Forms.Label();
            this.LabelAge = new System.Windows.Forms.Label();
            this.LabelCPR = new System.Windows.Forms.Label();
            this.FormClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(12, 47);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(100, 20);
            this.LastName.TabIndex = 0;
            // 
            // CPRNumber
            // 
            this.CPRNumber.Location = new System.Drawing.Point(12, 99);
            this.CPRNumber.Name = "CPRNumber";
            this.CPRNumber.Size = new System.Drawing.Size(100, 20);
            this.CPRNumber.TabIndex = 1;
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(12, 73);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(100, 20);
            this.Age.TabIndex = 2;
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(12, 21);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(100, 20);
            this.FirstName.TabIndex = 3;
            // 
            // CreateCustomerButton
            // 
            this.CreateCustomerButton.Location = new System.Drawing.Point(25, 140);
            this.CreateCustomerButton.Name = "CreateCustomerButton";
            this.CreateCustomerButton.Size = new System.Drawing.Size(75, 23);
            this.CreateCustomerButton.TabIndex = 4;
            this.CreateCustomerButton.Text = "Ok";
            this.CreateCustomerButton.UseVisualStyleBackColor = true;
            // 
            // LabelFirstName
            // 
            this.LabelFirstName.AutoSize = true;
            this.LabelFirstName.Location = new System.Drawing.Point(133, 24);
            this.LabelFirstName.Name = "LabelFirstName";
            this.LabelFirstName.Size = new System.Drawing.Size(57, 13);
            this.LabelFirstName.TabIndex = 5;
            this.LabelFirstName.Text = "First Name";
            // 
            // LabelLastName
            // 
            this.LabelLastName.AutoSize = true;
            this.LabelLastName.Location = new System.Drawing.Point(133, 50);
            this.LabelLastName.Name = "LabelLastName";
            this.LabelLastName.Size = new System.Drawing.Size(58, 13);
            this.LabelLastName.TabIndex = 6;
            this.LabelLastName.Text = "Last Name";
            // 
            // LabelAge
            // 
            this.LabelAge.AutoSize = true;
            this.LabelAge.Location = new System.Drawing.Point(133, 76);
            this.LabelAge.Name = "LabelAge";
            this.LabelAge.Size = new System.Drawing.Size(26, 13);
            this.LabelAge.TabIndex = 7;
            this.LabelAge.Text = "Age";
            // 
            // LabelCPR
            // 
            this.LabelCPR.AutoSize = true;
            this.LabelCPR.Location = new System.Drawing.Point(133, 102);
            this.LabelCPR.Name = "LabelCPR";
            this.LabelCPR.Size = new System.Drawing.Size(69, 13);
            this.LabelCPR.TabIndex = 8;
            this.LabelCPR.Text = "CPR Number";
            this.LabelCPR.Click += new System.EventHandler(this.LabelCPR_Click);
            // 
            // FormClose
            // 
            this.FormClose.Location = new System.Drawing.Point(116, 140);
            this.FormClose.Name = "FormClose";
            this.FormClose.Size = new System.Drawing.Size(75, 23);
            this.FormClose.TabIndex = 9;
            this.FormClose.Text = "Close";
            this.FormClose.UseVisualStyleBackColor = true;
            this.FormClose.Click += new System.EventHandler(this.FormClose_Click);
            // 
            // CreateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 177);
            this.Controls.Add(this.FormClose);
            this.Controls.Add(this.LabelCPR);
            this.Controls.Add(this.LabelAge);
            this.Controls.Add(this.LabelLastName);
            this.Controls.Add(this.LabelFirstName);
            this.Controls.Add(this.CreateCustomerButton);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.CPRNumber);
            this.Controls.Add(this.LastName);
            this.Name = "CreateCustomer";
            this.Text = "Create Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox CPRNumber;
        private System.Windows.Forms.TextBox Age;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.Button CreateCustomerButton;
        private System.Windows.Forms.Label LabelFirstName;
        private System.Windows.Forms.Label LabelLastName;
        private System.Windows.Forms.Label LabelAge;
        private System.Windows.Forms.Label LabelCPR;
        private System.Windows.Forms.Button FormClose;
    }
}