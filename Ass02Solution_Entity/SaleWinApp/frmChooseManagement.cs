using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleWinApp
{
    public partial class frmChooseManagement : Form
    {
        public frmChooseManagement()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMemberManagement frmMemberManagement = new frmMemberManagement();
            this.Hide();
            frmMemberManagement.ShowDialog();
            this.Show();
        }
    }
}
