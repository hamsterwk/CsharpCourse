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
    public delegate void SendItem(OrderItem newItem);
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent();
        }
        public OrderItem newItem = new OrderItem();
        public event SendItem SendItemEvent;
        private void AddItem_Load(object sender, EventArgs e)
        {
            //newItem = new OrderItem();
        }

        private void ConfirmItem_Click(object sender, EventArgs e)
        {
            if (Warning0.Visible == true || Warning1.Visible == true || Warning2.Visible == true)
            {
                Warning3.Visible = true;
                return;
            }
            Warning3.Visible = false;
            SendItemEvent(newItem);
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void itemNum_TextChanged(object sender, EventArgs e)
        {
            string text = this.itemNum.Text;
            int itemNum = H5.OrderIO.CheckInt(0,text);
            if (itemNum <0)
            {
                this.Warning1.Visible = true;
            }
            else
            {
                newItem.amount = itemNum;
                this.Warning1.Visible = false;
            }
        }

        private void ItemName_TextChanged(object sender, EventArgs e)
        {
            newItem.ItemName = this.ItemName.Text;
            if (newItem.ItemName == "")
            {
                this.Warning0.Visible = true;
            }
            else
            {
                this.Warning0.Visible = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string text = this.itemPrice.Text;
            int itemPrice = H5.OrderIO.CheckInt(0, text);
            if (itemPrice < 0)
            {
                this.Warning2.Visible = true;
            }
            else
            {
                newItem.Price = itemPrice;
                this.Warning2.Visible = false;
            }
        }

        private void Warning0_Click(object sender, EventArgs e)
        {

        }
    }
}
