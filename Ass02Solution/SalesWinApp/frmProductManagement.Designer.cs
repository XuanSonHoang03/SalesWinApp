namespace SalesWinApp
{
    partial class frmProductManagement
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
            btSort = new Button();
            tbUnitsInStock = new TextBox();
            tbUnitPrice = new TextBox();
            tbWeight = new TextBox();
            tbName = new TextBox();
            tbCategory = new TextBox();
            tbID = new TextBox();
            dgvProduct = new DataGridView();
            gbFilter = new GroupBox();
            btFilter = new Button();
            rbUnitsInStock = new RadioButton();
            rbUnitPrice = new RadioButton();
            label7 = new Label();
            label8 = new Label();
            tbTo = new TextBox();
            tbFrom = new TextBox();
            gbSearch = new GroupBox();
            tbSearch = new TextBox();
            cbSearch = new ComboBox();
            btDelete = new Button();
            btNew = new Button();
            btLoad = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            MemberID = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            gbFilter.SuspendLayout();
            gbSearch.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(305, 1);
            label1.Name = "label1";
            label1.Size = new Size(303, 38);
            label1.TabIndex = 39;
            label1.Text = "Product Management";
            label1.Click += label1_Click;
            // 
            // btSort
            // 
            btSort.Location = new Point(811, 403);
            btSort.Name = "btSort";
            btSort.Size = new Size(101, 42);
            btSort.TabIndex = 38;
            btSort.Text = "DESC";
            btSort.UseVisualStyleBackColor = true;
            btSort.Click += btSort_Click;
            // 
            // tbUnitsInStock
            // 
            tbUnitsInStock.Location = new Point(615, 195);
            tbUnitsInStock.Name = "tbUnitsInStock";
            tbUnitsInStock.Size = new Size(186, 27);
            tbUnitsInStock.TabIndex = 37;
            // 
            // tbUnitPrice
            // 
            tbUnitPrice.Location = new Point(615, 134);
            tbUnitPrice.Name = "tbUnitPrice";
            tbUnitPrice.Size = new Size(186, 27);
            tbUnitPrice.TabIndex = 36;
            // 
            // tbWeight
            // 
            tbWeight.Location = new Point(615, 73);
            tbWeight.Name = "tbWeight";
            tbWeight.Size = new Size(186, 27);
            tbWeight.TabIndex = 35;
            // 
            // tbName
            // 
            tbName.Location = new Point(201, 138);
            tbName.Name = "tbName";
            tbName.Size = new Size(185, 27);
            tbName.TabIndex = 34;
            // 
            // tbCategory
            // 
            tbCategory.Location = new Point(201, 199);
            tbCategory.Name = "tbCategory";
            tbCategory.Size = new Size(185, 27);
            tbCategory.TabIndex = 33;
            // 
            // tbID
            // 
            tbID.Location = new Point(201, 73);
            tbID.Name = "tbID";
            tbID.Size = new Size(185, 27);
            tbID.TabIndex = 32;
            // 
            // dgvProduct
            // 
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(41, 469);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.RowTemplate.Height = 29;
            dgvProduct.Size = new Size(836, 255);
            dgvProduct.TabIndex = 31;
            // 
            // gbFilter
            // 
            gbFilter.Controls.Add(btFilter);
            gbFilter.Controls.Add(rbUnitsInStock);
            gbFilter.Controls.Add(rbUnitPrice);
            gbFilter.Controls.Add(label7);
            gbFilter.Controls.Add(label8);
            gbFilter.Controls.Add(tbTo);
            gbFilter.Controls.Add(tbFrom);
            gbFilter.Location = new Point(405, 328);
            gbFilter.Name = "gbFilter";
            gbFilter.Size = new Size(396, 117);
            gbFilter.TabIndex = 30;
            gbFilter.TabStop = false;
            gbFilter.Text = "Filter";
            // 
            // btFilter
            // 
            btFilter.Location = new Point(271, 74);
            btFilter.Name = "btFilter";
            btFilter.Size = new Size(100, 37);
            btFilter.TabIndex = 40;
            btFilter.Text = "Filter";
            btFilter.UseVisualStyleBackColor = true;
            btFilter.Click += btFilter_Click;
            // 
            // rbUnitsInStock
            // 
            rbUnitsInStock.AutoSize = true;
            rbUnitsInStock.Location = new Point(129, 75);
            rbUnitsInStock.Name = "rbUnitsInStock";
            rbUnitsInStock.Size = new Size(119, 24);
            rbUnitsInStock.TabIndex = 43;
            rbUnitsInStock.TabStop = true;
            rbUnitsInStock.Text = "Units in Stock";
            rbUnitsInStock.UseVisualStyleBackColor = true;
            // 
            // rbUnitPrice
            // 
            rbUnitPrice.AutoSize = true;
            rbUnitPrice.Location = new Point(13, 75);
            rbUnitPrice.Name = "rbUnitPrice";
            rbUnitPrice.Size = new Size(93, 24);
            rbUnitPrice.TabIndex = 42;
            rbUnitPrice.TabStop = true;
            rbUnitPrice.Text = "Unit Price";
            rbUnitPrice.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 33);
            label7.Name = "label7";
            label7.Size = new Size(43, 20);
            label7.TabIndex = 40;
            label7.Text = "From";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(210, 33);
            label8.Name = "label8";
            label8.Size = new Size(25, 20);
            label8.TabIndex = 41;
            label8.Text = "To";
            // 
            // tbTo
            // 
            tbTo.Location = new Point(243, 26);
            tbTo.Name = "tbTo";
            tbTo.Size = new Size(125, 27);
            tbTo.TabIndex = 1;
            // 
            // tbFrom
            // 
            tbFrom.Location = new Point(74, 27);
            tbFrom.Name = "tbFrom";
            tbFrom.Size = new Size(125, 27);
            tbFrom.TabIndex = 0;
            // 
            // gbSearch
            // 
            gbSearch.Controls.Add(tbSearch);
            gbSearch.Controls.Add(cbSearch);
            gbSearch.Location = new Point(73, 334);
            gbSearch.Name = "gbSearch";
            gbSearch.Size = new Size(290, 93);
            gbSearch.TabIndex = 29;
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
            // btDelete
            // 
            btDelete.Location = new Point(676, 262);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(97, 39);
            btDelete.TabIndex = 28;
            btDelete.Text = "Delete";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // btNew
            // 
            btNew.Location = new Point(418, 262);
            btNew.Name = "btNew";
            btNew.Size = new Size(103, 39);
            btNew.TabIndex = 27;
            btNew.Text = "New";
            btNew.UseVisualStyleBackColor = true;
            btNew.Click += btNew_Click;
            // 
            // btLoad
            // 
            btLoad.Location = new Point(159, 262);
            btLoad.Name = "btLoad";
            btLoad.Size = new Size(105, 39);
            btLoad.TabIndex = 26;
            btLoad.Text = "Load";
            btLoad.UseVisualStyleBackColor = true;
            btLoad.Click += btLoad_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(521, 80);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 25;
            label6.Text = "Weight";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(505, 141);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 24;
            label5.Text = "Unit Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(479, 202);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 23;
            label4.Text = "Units in Stock";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 145);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 22;
            label3.Text = "ProductName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 206);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 21;
            label2.Text = "Category";
            // 
            // MemberID
            // 
            MemberID.AutoSize = true;
            MemberID.Location = new Point(90, 80);
            MemberID.Name = "MemberID";
            MemberID.Size = new Size(75, 20);
            MemberID.TabIndex = 20;
            MemberID.Text = "ProductID";
            // 
            // frmProductManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 736);
            Controls.Add(label1);
            Controls.Add(btSort);
            Controls.Add(tbUnitsInStock);
            Controls.Add(tbUnitPrice);
            Controls.Add(tbWeight);
            Controls.Add(tbName);
            Controls.Add(tbCategory);
            Controls.Add(tbID);
            Controls.Add(dgvProduct);
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
            Name = "frmProductManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmProductManagement";
            Load += frmProductManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            gbFilter.ResumeLayout(false);
            gbFilter.PerformLayout();
            gbSearch.ResumeLayout(false);
            gbSearch.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btSort;
        private TextBox tbUnitsInStock;
        private TextBox tbUnitPrice;
        private TextBox tbWeight;
        private TextBox tbName;
        private TextBox tbCategory;
        private TextBox tbID;
        private DataGridView dgvProduct;
        private GroupBox gbFilter;
        private GroupBox gbSearch;
        private TextBox tbSearch;
        private ComboBox cbSearch;
        private Button btDelete;
        private Button btNew;
        private Button btLoad;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label MemberID;
        private Button btFilter;
        private RadioButton rbUnitsInStock;
        private RadioButton rbUnitPrice;
        private Label label7;
        private Label label8;
        private TextBox tbTo;
        private TextBox tbFrom;
    }
}