using BusinessObject;
using DataAccess.Repository;
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
    public partial class frmMyOrder : Form
    {
        public MemberObject memberObject { get; set; }
        public IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        BindingSource BindingSource;
        public frmMyOrder()
        {
            InitializeComponent();
        }

        private void frmMyOrder_Load(object sender, EventArgs e)
        {
            tbPrice.ReadOnly = true;
            tbTotalOrder.ReadOnly = true;
            tbProductName.ReadOnly = true;
            tbQuantity.ReadOnly = true;
            tbTotal.ReadOnly = true;
            //dgvMyOrder.CellContentDoubleClick += new DataGridViewCellEventHandler(dgvMyOrder_CellContentDoubleClick);
            dgvMyOrder.DataSource = orderDetailRepository.GetOrderDetailByMemberId(memberObject.MemberId);
            if (dgvMyOrder.Rows.Count == 0)
            {
                MessageBox.Show(Text = "No Order in list");
                return;
            }
            List<OrderDetailObject> list = orderDetailRepository.GetOrderDetailByMemberId(memberObject.MemberId);
            foreach (OrderDetailObject orderDetail in list)
            {
                tbTotalOrder.Text = orderDetail.Quantity * orderDetail.UnitPrice + "";
            }
            LoadText(orderDetailRepository.GetOrderDetailByMemberId(memberObject.MemberId));
        }

        /*private void dgvMyOrder_CellContentDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            OrderDetailObject OrderDetail = GetOrderDetailByID();
            if (OrderDetail == null)
            {
                MessageBox.Show("No Order in list");
                return;
            }
            MessageBox.Show("Are you sure to delete this order?", "Delete", MessageBoxButtons.YesNo);
            orderDetailRepository.delete(OrderDetail.OrderId);
            MessageBox.Show("Delete successfully");
            dgvMyOrder.DataSource = orderDetailRepository.GetOrderDetailByMemberId(memberObject.MemberId);
        }*/

        private void LoadText(List<OrderDetailObject> orderDetailObjects)
        {
            //code to get the product properties from datagridview to text box
            tbProductName.Text = dgvMyOrder.CurrentRow.Cells[1].Value.ToString();
            tbQuantity.Text = dgvMyOrder.CurrentRow.Cells[2].Value.ToString();
            tbPrice.Text = dgvMyOrder.CurrentRow.Cells[3].Value.ToString();
            //caculate the total price from quantity * price
            //tbTotal.Text = int.Parse(tbQuantity.Text) * int.Parse(tbPrice.Text) + "";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OrderDetailObject OrderDetail = GetOrderDetailByID();
            if (OrderDetail == null)
            {
                MessageBox.Show("No Order in list");
                return;
            }
            if (MessageBox.Show("Are you sure to delete this order?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                orderDetailRepository.delete(OrderDetail.OrderId);
                MessageBox.Show("Delete successfully");
                dgvMyOrder.DataSource = orderDetailRepository.GetOrderDetailByMemberId(memberObject.MemberId);
            }
            
        }

        private OrderDetailObject GetOrderDetailByID()
        {
            return orderDetailRepository.GetOrderDetailByOrderId(int.Parse(dgvMyOrder.CurrentRow.Cells[0].Value.ToString()))[0];
        }

    }
}
