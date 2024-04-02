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
    public partial class frmProductOrder : Form
    {
        public IOrderDetailRepository OrderDetailRepository  = new OrderDetailRepository();
        public IProductRepository productRepository = new ProductRepository();
        public IOrderRepository OrderRepository = new OrderRepository();
        public ProductObject ProductObject { get; set; }
        public MemberObject memberObject { get; set; }
        public frmProductOrder()
        {
            InitializeComponent();
        }

        private void frmProductOrder_Load(object sender, EventArgs e)
        {
            tbID.Enabled = false;
            tbCategory.Enabled = false;
            tbUnitPrice.Enabled = false;
            tbWeight.Enabled = false;
            tbName.Enabled = false;

           LoadProduct();
        }

        private void LoadProduct()
        {
            tbID.Text = ProductObject.ProductId.ToString();
            tbName.Text = ProductObject.ProductName;
            tbCategory.Text = ProductObject.CategoryId.ToString();
            tbUnitPrice.Text = ProductObject.UnitPrice.ToString();
            tbWeight.Text = ProductObject.QuantityPerUnit.ToString();
            tbQuantity.Text = "0";
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (int.Parse(tbQuantity.Text) <= 0)
            {
                MessageBox.Show("Quantity must be greater than 0");
                return;
            }

            // Creating a new order
            OrderObject orderObject = new OrderObject
            {
                MemberId = memberObject.MemberId,
                OrderDate = DateTime.Now,
                RequiredDate = DateTime.Now,
                ShippedDate = DateTime.Now,
                Freight = 0
            };
            OrderRepository.insert(orderObject);

            // Retrieving the newly created orderId
            int orderId = GetLatestOrderId();

            if (orderId == 0)
            {
                MessageBox.Show("Failed to add order");
                return;
            }

            // Creating a new order detail
            OrderDetailObject orderDetailObject = new OrderDetailObject
            {
                OrderId = orderId,
                ProductId = ProductObject.ProductId,
                UnitPrice = ProductObject.UnitPrice,
                Quantity = int.Parse(tbQuantity.Text),
                Discount = 0
            };

            // Inserting order detail
            OrderDetailRepository.insert(orderDetailObject);

            // Updating product quantity in stock
            UpdateProductQuantity();

            this.Close();
        }

        private int GetLatestOrderId()
        {
            List<OrderObject> orders = OrderRepository.GetOrders();
            return orders.Count > 0 ? orders[orders.Count - 1].OrderId : 0;
        }
        
        private void UpdateProductQuantity()
        {
            // Change quantity of product in stock
            ProductObject.QuantityPerUnit = ProductObject.QuantityPerUnit - int.Parse(tbQuantity.Text);

            if (ProductObject.QuantityPerUnit < int.Parse(tbQuantity.Text))
            {
                MessageBox.Show("Quantity of product in stock is not enough");
                return;
            }

            // Update product in the repository
            productRepository.UpdateProduct(ProductObject);
            MessageBox.Show("Add product to order successfully");
            LoadProduct();
        }


    }
}
