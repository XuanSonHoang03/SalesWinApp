namespace SalesWinApp
{
    partial class frmOrderManagement
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
            tbID = new TextBox();
            tbMember = new TextBox();
            tbOrderTotal = new TextBox();
            tbOrderDate = new TextBox();
            groupBox1 = new GroupBox();
            dtEnd = new DateTimePicker();
            dtStart = new DateTimePicker();
            btSearch = new Button();
            label6 = new Label();
            label7 = new Label();
            dgvOrder = new DataGridView();
            btExportData = new Button();
            label5 = new Label();
            btLoad = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 88);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 0;
            label1.Text = "OrderID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 126);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "OrderDate";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 164);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 2;
            label3.Text = "Order Total";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 204);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 3;
            label4.Text = "Member";
            // 
            // tbID
            // 
            tbID.Location = new Point(135, 81);
            tbID.Name = "tbID";
            tbID.Size = new Size(184, 27);
            tbID.TabIndex = 4;
            // 
            // tbMember
            // 
            tbMember.Location = new Point(135, 197);
            tbMember.Name = "tbMember";
            tbMember.Size = new Size(184, 27);
            tbMember.TabIndex = 5;
            // 
            // tbOrderTotal
            // 
            tbOrderTotal.Location = new Point(135, 157);
            tbOrderTotal.Name = "tbOrderTotal";
            tbOrderTotal.Size = new Size(184, 27);
            tbOrderTotal.TabIndex = 6;
            // 
            // tbOrderDate
            // 
            tbOrderDate.Location = new Point(135, 119);
            tbOrderDate.Name = "tbOrderDate";
            tbOrderDate.Size = new Size(184, 27);
            tbOrderDate.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtEnd);
            groupBox1.Controls.Add(dtStart);
            groupBox1.Controls.Add(btSearch);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(362, 81);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(382, 162);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search";
            // 
            // dtEnd
            // 
            dtEnd.Location = new Point(113, 69);
            dtEnd.Name = "dtEnd";
            dtEnd.Size = new Size(250, 27);
            dtEnd.TabIndex = 15;
            // 
            // dtStart
            // 
            dtStart.Location = new Point(113, 35);
            dtStart.Name = "dtStart";
            dtStart.Size = new Size(250, 27);
            dtStart.TabIndex = 14;
            // 
            // btSearch
            // 
            btSearch.Location = new Point(104, 116);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(94, 29);
            btSearch.TabIndex = 12;
            btSearch.Text = "Search";
            btSearch.UseVisualStyleBackColor = true;
            btSearch.Click += btSearch_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 42);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 12;
            label6.Text = "Start Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 76);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 13;
            label7.Text = "End Date";
            // 
            // dgvOrder
            // 
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new Point(106, 269);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowHeadersWidth = 51;
            dgvOrder.RowTemplate.Height = 29;
            dgvOrder.Size = new Size(567, 193);
            dgvOrder.TabIndex = 9;
            // 
            // btExportData
            // 
            btExportData.Location = new Point(313, 479);
            btExportData.Name = "btExportData";
            btExportData.Size = new Size(146, 41);
            btExportData.TabIndex = 10;
            btExportData.Text = "Export Data";
            btExportData.UseVisualStyleBackColor = true;
            btExportData.Click += btExportData_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(268, 21);
            label5.Name = "label5";
            label5.Size = new Size(206, 31);
            label5.TabIndex = 11;
            label5.Text = "Order Management";
            // 
            // btLoad
            // 
            btLoad.Location = new Point(679, 269);
            btLoad.Name = "btLoad";
            btLoad.Size = new Size(94, 29);
            btLoad.TabIndex = 16;
            btLoad.Text = "Load";
            btLoad.UseVisualStyleBackColor = true;
            btLoad.Click += btLoad_Click;
            // 
            // frmOrderManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 532);
            Controls.Add(btLoad);
            Controls.Add(label5);
            Controls.Add(btExportData);
            Controls.Add(dgvOrder);
            Controls.Add(groupBox1);
            Controls.Add(tbOrderDate);
            Controls.Add(tbOrderTotal);
            Controls.Add(tbMember);
            Controls.Add(tbID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmOrderManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmOrder";
            Load += frmOrderManagement_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbID;
        private TextBox tbMember;
        private TextBox tbOrderTotal;
        private TextBox tbOrderDate;
        private GroupBox groupBox1;
        private Label label6;
        private Label label7;
        private DataGridView dgvOrder;
        private Button btExportData;
        private Label label5;
        private Button btSearch;
        private DateTimePicker dtEnd;
        private DateTimePicker dtStart;
        private Button btLoad;
    }
}