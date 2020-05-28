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
    public partial class MainForm : Form
    {
        public List<OrderItem> rightList;
        public int currentOid;
        public MainForm()
        {
            InitializeComponent();
            querySelections.SelectedIndex = 0;
            currentOid = -1;
            rightList = new List<OrderItem>();
            itemBindingSource.DataSource = rightList;
            orderBindingSource.DataSource = H5.OrderService.OrderList;
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            //bindingSource1.DataSource = H5.OrderService.OrderList;
        }

        void ReloadOrderList()
        {
            orderBindingSource.DataSource = new List<Order>();
            orderBindingSource.DataSource = OrderService.OrderList;
            int row = dataGridView1.Rows.Count;
            for (int i = 0; i < row; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[3].Value) != false)
                {
                    dataGridView1.Rows[i].Cells[3].Value = false;
                }
            }
        }
        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            AddOrder form2 = new AddOrder();
            form2.SendOrderEvent += SendOrderToList;
            form2.ShowDialog();
        }
        private void SendOrderToList(Order newOrder)
        {
            OrderService.AddOrder(newOrder);
            ReloadOrderList();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int row = dataGridView1.Rows.Count;
            List<int> delList = new List<int>();
            for (int i = 0; i < row; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[3].Value) == true)
                {
                    int index = int.Parse(this.dataGridView1.Rows[i].Cells[0].Value.ToString());
                    delList.Add(index);
                }
            }

            foreach(int index in delList)
            {
                OrderService.RemoveById(index);
            }
            ReloadOrderList();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //DataGridViewCell cell = this.dataGridView1.Rows[e.RowIndex].Cells[0];
                int index = int.Parse(this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                itemBindingSource.DataSource = new List<OrderItem>();
                currentOid = index;
                rightList = OrderService.QueryById(index).ItemList;
                itemBindingSource.DataSource = new List<OrderItem>();
                itemBindingSource.DataSource = rightList;
            }
            catch
            {
                return;
            }

        }

        private void labelOrderItem_Click(object sender, EventArgs e)
        {

        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            orderBindingSource.DataSource = new List<Order>();
            orderBindingSource.DataSource = OrderService.OrderList;
        }

        private void buttonDelItem_Click(object sender, EventArgs e)
        {

        }
        void NotFound()
        {
            WarningQuery.Visible = true;
            WarningQuery.Text = "未找到任何内容！";
        }
        void QueryById()
        {
            Order rtn = new Order(OrderService.OrderId);
            try
            {
                int index = int.Parse(queryText.Text);
                rtn = OrderService.QueryById(index);
                if (rtn == null)
                {
                    NotFound();
                    return;
                }
            }
            catch
            {
                WarningQuery.Visible = true;
                WarningQuery.Text = "输入非法！";
                return;
            }
            List<Order> result = new List<Order>();
            result.Add(rtn);
            ReloadOrderList();
            orderBindingSource.DataSource = new List<Order>();
            orderBindingSource.DataSource = result;
        }

        void QueryByCustomer()
        {
            string qText = queryText.Text;
            List<Order> result = OrderService.QueryByCustomer(qText);
            if (result.Count == 0)
            {
                NotFound();
                return;
            }
            ReloadOrderList();
            orderBindingSource.DataSource = new List<Order>();
            orderBindingSource.DataSource = result;
        }

        void QueryByItem()
        {
            string qText = queryText.Text;
            List<Order> result = OrderService.QueryByItem(qText);
            if (result.Count == 0)
            {
                NotFound();
                return;
            }
            ReloadOrderList();
            orderBindingSource.DataSource = new List<Order>();
            orderBindingSource.DataSource = result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = queryText.Text;
            if (text == "")
            {
                WarningQuery.Text = "关键字不能为空！";
                WarningQuery.Visible = true;
                return;
            }
            WarningQuery.Visible = false;
            switch (querySelections.SelectedIndex)
            {
                case 0:QueryById();break;
                case 1:QueryByCustomer();break;
                case 2:QueryByItem();break;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private string fromInput;
        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 3) return;
            Input InputForm = new Input();
            InputForm.SendInfoEvent += dealInfo;
            if (e.ColumnIndex == 0) InputForm.type = "string";
            else InputForm.type = "int";
            InputForm.ShowDialog();
            if (e.ColumnIndex == 0)
                this.dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = fromInput;
            else this.dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = int.Parse(fromInput);
            rightList = OrderService.QueryById(currentOid).ItemList;
            itemBindingSource.DataSource = new List<OrderItem>();
            itemBindingSource.DataSource = rightList;
            ReloadOrderList();
        }
        void dealInfo(string input)
        {
            fromInput = input;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
