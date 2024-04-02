namespace SalesWinApp
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
            btOrder = new Button();
            btProduct = new Button();
            SuspendLayout();
            // 
            // btMember
            // 
            btMember.Location = new Point(47, 50);
            btMember.Name = "btMember";
            btMember.Size = new Size(186, 83);
            btMember.TabIndex = 0;
            btMember.Text = "Member Management";
            btMember.UseVisualStyleBackColor = true;
            btMember.Click += btMember_Click;
            // 
            // btOrder
            // 
            btOrder.Location = new Point(260, 50);
            btOrder.Name = "btOrder";
            btOrder.Size = new Size(186, 83);
            btOrder.TabIndex = 1;
            btOrder.Text = "Order Management";
            btOrder.UseVisualStyleBackColor = true;
            btOrder.Click += btOrder_Click;
            // 
            // btProduct
            // 
            btProduct.Location = new Point(480, 50);
            btProduct.Name = "btProduct";
            btProduct.Size = new Size(186, 83);
            btProduct.TabIndex = 2;
            btProduct.Text = "Product Management ";
            btProduct.UseVisualStyleBackColor = true;
            btProduct.Click += btProduct_Click;
            // 
            // frmChooseManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 195);
            Controls.Add(btProduct);
            Controls.Add(btOrder);
            Controls.Add(btMember);
            Name = "frmChooseManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmChooseManagement";
            ResumeLayout(false);
        }

        #endregion

        private Button btMember;
        private Button btOrder;
        private Button btProduct;
    }
}