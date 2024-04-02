using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmChooseManagement : Form
    {
        public frmChooseManagement()
        {
            InitializeComponent();
        }

        private void btMember_Click(object sender, EventArgs e)
        {
            frmMemberManagement frmMemberManagement = new frmMemberManagement();
            this.Hide();
            frmMemberManagement.ShowDialog();
            this.Show();
        }

        private void btOrder_Click(object sender, EventArgs e)
        {
            frmOrderManagement frmOrderManagement = new frmOrderManagement();
            this.Hide();
            frmOrderManagement.ShowDialog();
            this.Show();
        }

        private void btProduct_Click(object sender, EventArgs e)
        {
            frmProductManagement frmProductManagement = new frmProductManagement();
            this.Hide();
            frmProductManagement.ShowDialog();
            this.Show();
        }
    }
}
