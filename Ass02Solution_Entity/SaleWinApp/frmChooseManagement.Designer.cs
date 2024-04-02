namespace SaleWinApp
{
    partial class frmChooseManagement
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
            btMember = new Button();
            btProduct = new Button();
            btOrder = new Button();
            SuspendLayout();
            // 
            // btMember
            // 
            btMember.Location = new Point(43, 74);
            btMember.Name = "btMember";
            btMember.Size = new Size(178, 90);
            btMember.TabIndex = 0;
            btMember.Text = "Member Management";
            btMember.UseVisualStyleBackColor = true;
            btMember.Click += button1_Click;
            // 
            // btProduct
            // 
            btProduct.Location = new Point(277, 74);
            btProduct.Name = "btProduct";
            btProduct.Size = new Size(178, 90);
            btProduct.TabIndex = 1;
            btProduct.Text = "Product Management";
            btProduct.UseVisualStyleBackColor = true;
            // 
            // btOrder
            // 
            btOrder.Location = new Point(511, 74);
            btOrder.Name = "btOrder";
            btOrder.Size = new Size(178, 90);
            btOrder.TabIndex = 2;
            btOrder.Text = "Order Management";
            btOrder.UseVisualStyleBackColor = true;
            // 
            // frmChooseManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 241);
            Controls.Add(btOrder);
            Controls.Add(btProduct);
            Controls.Add(btMember);
            Name = "frmChooseManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmChooseManagement";
            ResumeLayout(false);
        }

        #endregion

        private Button btMember;
        private Button btProduct;
        private Button btOrder;
    }
}