namespace SaleWinApp
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbUsername = new TextBox();
            label1 = new Label();
            btLogin = new Button();
            label2 = new Label();
            tbPassword = new TextBox();
            LOGIN = new Label();
            SuspendLayout();
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(190, 112);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(196, 27);
            tbUsername.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 119);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // btLogin
            // 
            btLogin.Location = new Point(207, 242);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(112, 42);
            btLogin.TabIndex = 2;
            btLogin.Text = "Login";
            btLogin.UseVisualStyleBackColor = true;
            btLogin.Click += btLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 176);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(190, 169);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(196, 27);
            tbPassword.TabIndex = 1;
            // 
            // LOGIN
            // 
            LOGIN.AutoSize = true;
            LOGIN.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Italic, GraphicsUnit.Point);
            LOGIN.Location = new Point(190, 27);
            LOGIN.Name = "LOGIN";
            LOGIN.Size = new Size(153, 60);
            LOGIN.TabIndex = 5;
            LOGIN.Text = "LOGIN";
            // 
            // frmLogin
            // 
            AcceptButton = btLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 320);
            Controls.Add(LOGIN);
            Controls.Add(label2);
            Controls.Add(tbPassword);
            Controls.Add(btLogin);
            Controls.Add(label1);
            Controls.Add(tbUsername);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbUsername;
        private Label label1;
        private Button btLogin;
        private Label label2;
        private TextBox tbPassword;
        private Label LOGIN;
    }
}
