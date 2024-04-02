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
    public partial class frmOrderManagement : Form
    {
        public IOrderRepository OrderRepository = new OrderRepository();
        BindingSource BindingSource;
        public frmOrderManagement()
        {
            InitializeComponent();
        }

        private void frmOrderManagement_Load(object sender, EventArgs e)
        {
            LoadOrderList();
            dgvOrder.CellDoubleClick += DgvOrder_CellDoubleClick;
        }

        private void DgvOrder_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadOrderList()
        {
            try
            {
                var orderList = OrderRepository.GetOrders();
                if (orderList == null || orderList.Count == 0)
                {
                    MessageBox.Show("No order in list");
                    return;
                }
                BindingSource = new BindingSource();
                BindingSource.DataSource = orderList;

                tbID.DataBindings.Clear();
                tbMember.DataBindings.Clear();
                tbOrderDate.DataBindings.Clear();
                tbOrderTotal.DataBindings.Clear();

                tbID.DataBindings.Add("Text", BindingSource, "OrderId");
                tbMember.DataBindings.Add("Text", BindingSource, "MemberId");
                tbOrderDate.DataBindings.Add("Text", BindingSource, "OrderDate");

                dgvOrder.DataSource = null;
                dgvOrder.DataSource = BindingSource;

                btExportData.Enabled = orderList.Count > 0;

                SetTextBoxesReadOnly(true);

                CalculateAndSetTotalOrder();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void CalculateAndSetTotalOrder()
        {
            if (BindingSource.Current != null)
            {
                var currentOrder = (OrderObject)BindingSource.Current;
                try
                {
                    string total = OrderRepository.GetTotalOrderByID(currentOrder.OrderId.ToString());
                    tbOrderTotal.Text = total;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error calculating total order: " + ex.Message);
                    tbOrderTotal.Text = "0"; // or any default value
                }
            }
            else
            {
                tbOrderTotal.Text = "0"; // or any default value if there's no current order
            }
        }


        private void SetTextBoxesReadOnly(bool isReadOnly)
        {
            tbID.ReadOnly = isReadOnly;
            tbMember.ReadOnly = isReadOnly;
            tbOrderDate.ReadOnly = isReadOnly;
            tbOrderTotal.ReadOnly = isReadOnly;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            DateTime dateTime = dtStart.Value;
            DateTime dateTime2 = dtEnd.Value;

            try
            {
                var orderList = OrderRepository.SearchByOrderDate(dateTime, dateTime2);
                if (orderList == null || orderList.Count == 0)
                {
                    MessageBox.Show("No order in list");
                    return;
                }
                BindingSource = new BindingSource();
                BindingSource.DataSource = orderList;

                tbID.DataBindings.Clear();
                tbMember.DataBindings.Clear();
                tbOrderDate.DataBindings.Clear();
                tbOrderTotal.DataBindings.Clear();

                tbID.DataBindings.Add("Text", BindingSource, "OrderId");
                tbMember.DataBindings.Add("Text", BindingSource, "MemberId");
                tbOrderDate.DataBindings.Add("Text", BindingSource, "OrderDate");

                dgvOrder.DataSource = null;
                dgvOrder.DataSource = BindingSource;

                btExportData.Enabled = orderList.Count > 0;

                SetTextBoxesReadOnly(true);

                CalculateAndSetTotalOrder();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            LoadOrderList();
        }

        private void btExportData_Click(object sender, EventArgs e)
        {
            //code to export data to file
            try
            {
                var orderList = (List<OrderObject>)BindingSource.DataSource;
                if (orderList == null || orderList.Count == 0)
                {
                    MessageBox.Show("No order in list");
                    return;
                }
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV file (*.txt)|*.txt";
                saveFileDialog.Title = "Export data to CSV file";
                saveFileDialog.ShowDialog();

                if (saveFileDialog.FileName != "")
                {
                    System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog.OpenFile();
                    fs.Close();
                    System.IO.File.WriteAllText(saveFileDialog.FileName, "OrderId,MemberId,OrderDate,Freight\r\n");
                    foreach (var order in orderList)
                    {
                        System.IO.File.AppendAllText(saveFileDialog.FileName, order.OrderId + "," + order.MemberId + "," + order.OrderDate + "," + order.Freight + "\r\n");
                    }
                    MessageBox.Show("Export data to CSV file successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
