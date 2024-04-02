namespace SalesWinApp
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
            MemberID = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btLoad = new Button();
            btNew = new Button();
            btDelete = new Button();
            gbSearch = new GroupBox();
            tbSearch = new TextBox();
            cbSearch = new ComboBox();
            gbFilter = new GroupBox();
            cbFilterList = new ComboBox();
            cbFilter = new ComboBox();
            dgvMember = new DataGridView();
            tbID = new TextBox();
            tbPassword = new TextBox();
            tbEmail = new TextBox();
            tbCompany = new TextBox();
            tbCity = new TextBox();
            tbCountry = new TextBox();
            btSort = new Button();
            label1 = new Label();
            gbSearch.SuspendLayout();
            gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMember).BeginInit();
            SuspendLayout();
            // 
            // MemberID
            // 
            MemberID.AutoSize = true;
            MemberID.Location = new Point(61, 79);
            MemberID.Name = "MemberID";
            MemberID.Size = new Size(80, 20);
            MemberID.TabIndex = 0;
            MemberID.Text = "MemberID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 205);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 144);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(498, 201);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 3;
            label4.Text = "Country";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(524, 140);
            label5.Name = "label5";
            label5.Size = new Size(34, 20);
            label5.TabIndex = 4;
            label5.Text = "City";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(446, 79);
            label6.Name = "label6";
            label6.Size = new Size(112, 20);
            label6.TabIndex = 5;
            label6.Text = "CompanyName";
            // 
            // btLoad
            // 
            btLoad.Location = new Point(123, 277);
            btLoad.Name = "btLoad";
            btLoad.Size = new Size(105, 39);
            btLoad.TabIndex = 6;
            btLoad.Text = "Load";
            btLoad.UseVisualStyleBackColor = true;
            // 
            // btNew
            // 
            btNew.Location = new Point(382, 277);
            btNew.Name = "btNew";
            btNew.Size = new Size(103, 39);
            btNew.TabIndex = 7;
            btNew.Text = "New";
            btNew.UseVisualStyleBackColor = true;
            btNew.Click += btNew_Click;
            // 
            // btDelete
            // 
            btDelete.Location = new Point(640, 277);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(97, 39);
            btDelete.TabIndex = 8;
            btDelete.Text = "Delete";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // gbSearch
            // 
            gbSearch.Controls.Add(tbSearch);
            gbSearch.Controls.Add(cbSearch);
            gbSearch.Location = new Point(36, 346);
            gbSearch.Name = "gbSearch";
            gbSearch.Size = new Size(290, 93);
            gbSearch.TabIndex = 9;
            gbSearch.TabStop = false;
            gbSearch.Text = "Search";
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(108, 35);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(154, 27);
            tbSearch.TabIndex = 1;
            tbSearch.TextChanged += tbSearch_TextChanged;
            // 
            // cbSearch
            // 
            cbSearch.FormattingEnabled = true;
            cbSearch.Items.AddRange(new object[] { "ID", "Email" });
            cbSearch.Location = new Point(17, 35);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(70, 28);
            cbSearch.TabIndex = 0;
            // 
            // gbFilter
            // 
            gbFilter.Controls.Add(cbFilterList);
            gbFilter.Controls.Add(cbFilter);
            gbFilter.Location = new Point(402, 346);
            gbFilter.Name = "gbFilter";
            gbFilter.Size = new Size(320, 93);
            gbFilter.TabIndex = 10;
            gbFilter.TabStop = false;
            gbFilter.Text = "Filter";
            // 
            // cbFilterList
            // 
            cbFilterList.FormattingEnabled = true;
            cbFilterList.Location = new Point(152, 34);
            cbFilterList.Name = "cbFilterList";
            cbFilterList.Size = new Size(143, 28);
            cbFilterList.TabIndex = 3;
            cbFilterList.SelectedIndexChanged += cbFilterList_SelectedIndexChanged;
            // 
            // cbFilter
            // 
            cbFilter.FormattingEnabled = true;
            cbFilter.Items.AddRange(new object[] { "City", "Country" });
            cbFilter.Location = new Point(12, 34);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(110, 28);
            cbFilter.TabIndex = 2;
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // dgvMember
            // 
            dgvMember.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMember.Location = new Point(4, 445);
            dgvMember.Name = "dgvMember";
            dgvMember.RowHeadersWidth = 51;
            dgvMember.RowTemplate.Height = 29;
            dgvMember.Size = new Size(836, 255);
            dgvMember.TabIndex = 11;
            // 
            // tbID
            // 
            tbID.Location = new Point(165, 72);
            tbID.Name = "tbID";
            tbID.Size = new Size(185, 27);
            tbID.TabIndex = 12;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(165, 198);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(185, 27);
            tbPassword.TabIndex = 13;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(165, 137);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(185, 27);
            tbEmail.TabIndex = 14;
            // 
            // tbCompany
            // 
            tbCompany.Location = new Point(579, 72);
            tbCompany.Name = "tbCompany";
            tbCompany.Size = new Size(186, 27);
            tbCompany.TabIndex = 15;
            // 
            // tbCity
            // 
            tbCity.Location = new Point(579, 133);
            tbCity.Name = "tbCity";
            tbCity.Size = new Size(186, 27);
            tbCity.TabIndex = 16;
            // 
            // tbCountry
            // 
            tbCountry.Location = new Point(579, 194);
            tbCountry.Name = "tbCountry";
            tbCountry.Size = new Size(186, 27);
            tbCountry.TabIndex = 17;
            // 
            // btSort
            // 
            btSort.Location = new Point(739, 397);
            btSort.Name = "btSort";
            btSort.Size = new Size(101, 42);
            btSort.TabIndex = 18;
            btSort.Text = "DESC";
            btSort.UseVisualStyleBackColor = true;
            btSort.Click += DESC_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(268, 9);
            label1.Name = "label1";
            label1.Size = new Size(311, 38);
            label1.TabIndex = 19;
            label1.Text = "Member Management";
            // 
            // frmMemberManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 701);
            Controls.Add(label1);
            Controls.Add(btSort);
            Controls.Add(tbCountry);
            Controls.Add(tbCity);
            Controls.Add(tbCompany);
            Controls.Add(tbEmail);
            Controls.Add(tbPassword);
            Controls.Add(tbID);
            Controls.Add(dgvMember);
            Controls.Add(gbFilter);
            Controls.Add(gbSearch);
            Controls.Add(btDelete);
            Controls.Add(btNew);
            Controls.Add(btLoad);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(MemberID);
            Name = "frmMemberManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMember";
            Load += frmMemberManagement_Load;
            gbSearch.ResumeLayout(false);
            gbSearch.PerformLayout();
            gbFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMember).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MemberID;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btLoad;
        private Button btNew;
        private Button btDelete;
        private GroupBox gbSearch;
        private GroupBox gbFilter;
        private DataGridView dgvMember;
        private TextBox tbID;
        private TextBox tbPassword;
        private TextBox tbEmail;
        private TextBox tbCompany;
        private TextBox tbCity;
        private TextBox tbCountry;
        private Button btSort;
        private TextBox tbSearch;
        private ComboBox cbSearch;
        private ComboBox cbFilterList;
        private ComboBox cbFilter;
        private Label label1;
    }
}