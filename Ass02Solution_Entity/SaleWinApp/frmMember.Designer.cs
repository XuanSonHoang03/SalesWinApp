namespace SaleWinApp
{
    partial class frmMember
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
            btSave = new Button();
            ID = new Label();
            tbID = new TextBox();
            tbEmail = new TextBox();
            label2 = new Label();
            tbPassword = new TextBox();
            label3 = new Label();
            tbCompany = new TextBox();
            label4 = new Label();
            tbCity = new TextBox();
            label5 = new Label();
            tbCountry = new TextBox();
            label6 = new Label();
            btCancel = new Button();
            lbWelcome = new Label();
            btOrder = new Button();
            SuspendLayout();
            // 
            // btSave
            // 
            btSave.Location = new Point(161, 318);
            btSave.Name = "btSave";
            btSave.Size = new Size(101, 42);
            btSave.TabIndex = 0;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(101, 107);
            ID.Name = "ID";
            ID.Size = new Size(24, 20);
            ID.TabIndex = 1;
            ID.Text = "ID";
            // 
            // tbID
            // 
            tbID.Location = new Point(161, 100);
            tbID.Name = "tbID";
            tbID.Size = new Size(125, 27);
            tbID.TabIndex = 2;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(161, 162);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(125, 27);
            tbEmail.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 165);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 3;
            label2.Text = "Email";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(161, 228);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(125, 27);
            tbPassword.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 235);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // tbCompany
            // 
            tbCompany.Location = new Point(476, 100);
            tbCompany.Name = "tbCompany";
            tbCompany.Size = new Size(125, 27);
            tbCompany.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(334, 107);
            label4.Name = "label4";
            label4.Size = new Size(116, 20);
            label4.TabIndex = 7;
            label4.Text = "Company Name";
            // 
            // tbCity
            // 
            tbCity.Location = new Point(476, 162);
            tbCity.Name = "tbCity";
            tbCity.Size = new Size(125, 27);
            tbCity.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(416, 169);
            label5.Name = "label5";
            label5.Size = new Size(34, 20);
            label5.TabIndex = 9;
            label5.Text = "City";
            // 
            // tbCountry
            // 
            tbCountry.Location = new Point(476, 228);
            tbCountry.Name = "tbCountry";
            tbCountry.Size = new Size(125, 27);
            tbCountry.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(390, 235);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 11;
            label6.Text = "Country";
            // 
            // btCancel
            // 
            btCancel.Location = new Point(433, 318);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(101, 42);
            btCancel.TabIndex = 13;
            btCancel.Text = "Cancel";
            btCancel.UseVisualStyleBackColor = true;
            // 
            // lbWelcome
            // 
            lbWelcome.AutoSize = true;
            lbWelcome.Font = new Font("Segoe UI", 28.2F, FontStyle.Italic, GraphicsUnit.Point);
            lbWelcome.Location = new Point(232, 9);
            lbWelcome.Name = "lbWelcome";
            lbWelcome.Size = new Size(228, 62);
            lbWelcome.TabIndex = 14;
            lbWelcome.Text = "Welcome ";
            // 
            // btOrder
            // 
            btOrder.Location = new Point(298, 318);
            btOrder.Name = "btOrder";
            btOrder.Size = new Size(101, 42);
            btOrder.TabIndex = 15;
            btOrder.Text = "Order";
            btOrder.UseVisualStyleBackColor = true;
            // 
            // frmMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 387);
            Controls.Add(btOrder);
            Controls.Add(lbWelcome);
            Controls.Add(btCancel);
            Controls.Add(tbCountry);
            Controls.Add(label6);
            Controls.Add(tbCity);
            Controls.Add(label5);
            Controls.Add(tbCompany);
            Controls.Add(label4);
            Controls.Add(tbPassword);
            Controls.Add(label3);
            Controls.Add(tbEmail);
            Controls.Add(label2);
            Controls.Add(tbID);
            Controls.Add(ID);
            Controls.Add(btSave);
            Name = "frmMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMember";
            Load += frmMember_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btSave;
        private Label ID;
        private TextBox tbID;
        private TextBox tbEmail;
        private Label label2;
        private TextBox tbPassword;
        private Label label3;
        private TextBox tbCompany;
        private Label label4;
        private TextBox tbCity;
        private Label label5;
        private TextBox tbCountry;
        private Label label6;
        private Button btCancel;
        private Label lbWelcome;
        private Button btOrder;
    }
}