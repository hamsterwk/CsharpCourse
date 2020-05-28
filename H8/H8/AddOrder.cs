using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using H5;
namespace H8
{
    public delegate void SendOrder(Order newOrder);
    public partial class AddOrder : Form
    {
        public Order newOrder;
        public List<OrderItem> items = new List<OrderItem>();
        public event SendOrder SendOrderEvent;
        public AddOrder()
        {
            InitializeComponent();
            newOrder = new Order(OrderService.OrderId);
            itemBindingSource1.DataSource = items;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CustomerName_TextChanged(object sender, EventArgs e)
        {
            if (CustomerName.Text == "")
            {
                WarningNull.Visible = true;
            }
            else WarningNull.Visible = false;
        }
        public string NewOrderCustomerName { get { return newOrder.customer.name; } set { newOrder.customer.name = value; } }
        public int NewOrderPrice { get { return newOrder.totalPrice; } set { newOrder.totalPrice = value; } }
        private void AddOrder_Load(object sender, EventArgs e)
        {

            CustomerName.DataBindings.Add("Text", this, "NewOrderCustomerName");
            TotalPrice.DataBindings.Add("Text", this, "NewOrderPrice");
        }

        private void AddItemToOrder_Click(object sender, EventArgs e)
        {
            AddItem form2 = new AddItem();
            form2.SendItemEvent += SendItemToOrder;
            form2.ShowDialog();
            itemBindingSource1.DataSource = newOrder.ItemList;
        }
        private void SendItemToOrder(OrderItem newItem)
        {
            newOrder.ItemList.Add(newItem);
            itemBindingSource1.DataSource = new List<OrderItem>();
            itemBindingSource1.DataSource = newOrder.ItemList;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ConfirmOrder_Click(object sender, EventArgs e)
        {
            if (CustomerName.Text == "")
            {
                Warning1.Visible = true;
                Warning1.Text = "客户名不能为空！";
                return;
            }else if (newOrder.ItemList.Count == 0)
            {
                Warning1.Visible = true;
                Warning1.Text = "订单不能为空！";
                return;
            }
            Warning1.Visible = false;
            SendOrderEvent(newOrder);
            this.Close();
        }

    }
}
