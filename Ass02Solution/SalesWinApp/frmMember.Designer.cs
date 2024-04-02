namespace SalesWinApp
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tbID = new TextBox();
            tbPassword = new TextBox();
            tbEmail = new TextBox();
            tbCountry = new TextBox();
            tbCity = new TextBox();
            tbCompany = new TextBox();
            btSave = new Button();
            btView = new Button();
            btCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 69);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 189);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 125);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(415, 185);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 3;
            label4.Text = "Country";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(441, 125);
            label5.Name = "label5";
            label5.Size = new Size(34, 20);
            label5.TabIndex = 4;
            label5.Text = "City";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(363, 65);
            label6.Name = "label6";
            label6.Size = new Size(112, 20);
            label6.TabIndex = 5;
            label6.Text = "CompanyName";
            // 
            // tbID
            // 
            tbID.Location = new Point(157, 62);
            tbID.Name = "tbID";
            tbID.Size = new Size(125, 27);
            tbID.TabIndex = 6;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(157, 182);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(125, 27);
            tbPassword.TabIndex = 8;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(157, 118);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(125, 27);
            tbEmail.TabIndex = 9;
            // 
            // tbCountry
            // 
            tbCountry.Location = new Point(512, 178);
            tbCountry.Name = "tbCountry";
            tbCountry.Size = new Size(125, 27);
            tbCountry.TabIndex = 10;
            // 
            // tbCity
            // 
            tbCity.Location = new Point(512, 118);
            tbCity.Name = "tbCity";
            tbCity.Size = new Size(125, 27);
            tbCity.TabIndex = 11;
            // 
            // tbCompany
            // 
            tbCompany.Location = new Point(512, 58);
            tbCompany.Name = "tbCompany";
            tbCompany.Size = new Size(125, 27);
            tbCompany.TabIndex = 12;
            // 
            // btSave
            // 
            btSave.Location = new Point(111, 279);
            btSave.Name = "btSave";
            btSave.Size = new Size(111, 46);
            btSave.TabIndex = 13;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // btView
            // 
            btView.Location = new Point(299, 279);
            btView.Name = "btView";
            btView.Size = new Size(115, 46);
            btView.TabIndex = 14;
            btView.Text = "View Order";
            btView.UseVisualStyleBackColor = true;
            btView.Click += btView_Click;
            // 
            // btCancel
            // 
            btCancel.Location = new Point(500, 279);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(113, 46);
            btCancel.TabIndex = 15;
            btCancel.Text = "Cancel";
            btCancel.UseVisualStyleBackColor = true;
            btCancel.Click += btCancel_Click;
            // 
            // frmMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 412);
            Controls.Add(btCancel);
            Controls.Add(btView);
            Controls.Add(btSave);
            Controls.Add(tbCompany);
            Controls.Add(tbCity);
            Controls.Add(tbCountry);
            Controls.Add(tbEmail);
            Controls.Add(tbPassword);
            Controls.Add(tbID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMember";
            Load += frmMember_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tbID;
        private TextBox tbPassword;
        private TextBox tbEmail;
        private TextBox tbCountry;
        private TextBox tbCity;
        private TextBox tbCompany;
        private Button btSave;
        private Button btView;
        private Button btCancel;
    }
}