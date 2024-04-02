namespace SaleWinApp
{
    partial class frmMemberManagement
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
            btDelete = new Button();
            btCancel = new Button();
            tbCountry = new TextBox();
            label6 = new Label();
            tbCity = new TextBox();
            label5 = new Label();
            tbCompany = new TextBox();
            label4 = new Label();
            tbPassword = new TextBox();
            label3 = new Label();
            tbEmail = new TextBox();
            label2 = new Label();
            tbID = new TextBox();
            ID = new Label();
            btNew = new Button();
            label1 = new Label();
            dgvMember = new DataGridView();
            groupBox1 = new GroupBox();
            tbSearch = new TextBox();
            cbSearch = new ComboBox();
            groupBox2 = new GroupBox();
            cbProperties = new ComboBox();
            cbFilter = new ComboBox();
            button1 = new Button();
            btLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMember).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btDelete
            // 
            btDelete.Location = new Point(407, 294);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(111, 50);
            btDelete.TabIndex = 30;
            btDelete.Text = "Delete";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // btCancel
            // 
            btCancel.Location = new Point(626, 294);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(111, 50);
            btCancel.TabIndex = 29;
            btCancel.Text = "Cancel";
            btCancel.UseVisualStyleBackColor = true;
            // 
            // tbCountry
            // 
            tbCountry.Location = new Point(626, 227);
            tbCountry.Name = "tbCountry";
            tbCountry.Size = new Size(170, 27);
            tbCountry.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(540, 234);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 27;
            label6.Text = "Country";
            // 
            // tbCity
            // 
            tbCity.Location = new Point(626, 161);
            tbCity.Name = "tbCity";
            tbCity.Size = new Size(170, 27);
            tbCity.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(566, 168);
            label5.Name = "label5";
            label5.Size = new Size(34, 20);
            label5.TabIndex = 25;
            label5.Text = "City";
            // 
            // tbCompany
            // 
            tbCompany.Location = new Point(626, 99);
            tbCompany.Name = "tbCompany";
            tbCompany.Size = new Size(170, 27);
            tbCompany.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(484, 106);
            label4.Name = "label4";
            label4.Size = new Size(116, 20);
            label4.TabIndex = 23;
            label4.Text = "Company Name";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(193, 227);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(179, 27);
            tbPassword.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 234);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 21;
            label3.Text = "Password";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(193, 161);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(179, 27);
            tbEmail.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 164);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 19;
            label2.Text = "Email";
            // 
            // tbID
            // 
            tbID.Location = new Point(193, 99);
            tbID.Name = "tbID";
            tbID.Size = new Size(179, 27);
            tbID.TabIndex = 18;
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(133, 106);
            ID.Name = "ID";
            ID.Size = new Size(24, 20);
            ID.TabIndex = 17;
            ID.Text = "ID";
            // 
            // btNew
            // 
            btNew.Location = new Point(193, 294);
            btNew.Name = "btNew";
            btNew.Size = new Size(111, 50);
            btNew.TabIndex = 16;
            btNew.Text = "New";
            btNew.UseVisualStyleBackColor = true;
            btNew.Click += btNew_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 28.2F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(210, 18);
            label1.Name = "label1";
            label1.Size = new Size(479, 54);
            label1.TabIndex = 31;
            label1.Text = "Member Management";
            // 
            // dgvMember
            // 
            dgvMember.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMember.Location = new Point(12, 468);
            dgvMember.Name = "dgvMember";
            dgvMember.RowHeadersWidth = 51;
            dgvMember.RowTemplate.Height = 29;
            dgvMember.Size = new Size(886, 267);
            dgvMember.TabIndex = 32;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbSearch);
            groupBox1.Controls.Add(cbSearch);
            groupBox1.Location = new Point(55, 376);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(332, 86);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search";
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(128, 37);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(179, 27);
            tbSearch.TabIndex = 36;
            tbSearch.TextChanged += tbSearch_TextChanged;
            // 
            // cbSearch
            // 
            cbSearch.FormattingEnabled = true;
            cbSearch.Items.AddRange(new object[] { "ID", "Email" });
            cbSearch.Location = new Point(20, 37);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(91, 28);
            cbSearch.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbProperties);
            groupBox2.Controls.Add(cbFilter);
            groupBox2.Location = new Point(434, 376);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(286, 86);
            groupBox2.TabIndex = 34;
            groupBox2.TabStop = false;
            groupBox2.Text = "Filter";
            // 
            // cbProperties
            // 
            cbProperties.FormattingEnabled = true;
            cbProperties.Location = new Point(152, 37);
            cbProperties.Name = "cbProperties";
            cbProperties.Size = new Size(103, 28);
            cbProperties.TabIndex = 37;
            cbProperties.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // cbFilter
            // 
            cbFilter.FormattingEnabled = true;
            cbFilter.Items.AddRange(new object[] { "City", "Country" });
            cbFilter.Location = new Point(22, 37);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(91, 28);
            cbFilter.TabIndex = 38;
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(758, 424);
            button1.Name = "button1";
            button1.Size = new Size(117, 38);
            button1.TabIndex = 35;
            button1.Text = "DESC";
            button1.UseVisualStyleBackColor = true;
            // 
            // btLoad
            // 
            btLoad.Location = new Point(758, 376);
            btLoad.Name = "btLoad";
            btLoad.Size = new Size(117, 38);
            btLoad.TabIndex = 36;
            btLoad.Text = "Load";
            btLoad.UseVisualStyleBackColor = true;
            btLoad.Click += btLoad_Click;
            // 
            // frmMemberManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 747);
            Controls.Add(btLoad);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgvMember);
            Controls.Add(label1);
            Controls.Add(btDelete);
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
            Controls.Add(btNew);
            Name = "frmMemberManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMemberManagement";
            Load += frmMemberManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMember).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btDelete;
        private Button btCancel;
        private TextBox tbCountry;
        private Label label6;
        private TextBox tbCity;
        private Label label5;
        private TextBox tbCompany;
        private Label label4;
        private TextBox tbPassword;
        private Label label3;
        private TextBox tbEmail;
        private Label label2;
        private TextBox tbID;
        private Label ID;
        private Button btNew;
        private Label label1;
        private DataGridView dgvMember;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button1;
        private TextBox tbSearch;
        private ComboBox cbSearch;
        private ComboBox cbProperties;
        private ComboBox cbFilter;
        private Button btLoad;
    }
}