namespace H8
{
    partial class AddOrder
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrder));
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerName = new System.Windows.Forms.TextBox();
            this.AddItem = new System.Windows.Forms.Button();
            this.WarningNull = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TotalPrice = new System.Windows.Forms.Label();
            this.ConfirmOrder = new System.Windows.Forms.Button();
            this.Warning1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "客户名：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CustomerName
            // 
            this.CustomerName.Location = new System.Drawing.Point(64, 29);
            this.CustomerName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(76, 21);
            this.CustomerName.TabIndex = 2;
            this.CustomerName.TextChanged += new System.EventHandler(this.CustomerName_TextChanged);
            // 
            // AddItem
            // 
            this.AddItem.Location = new System.Drawing.Point(209, 23);
            this.AddItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(107, 30);
            this.AddItem.TabIndex = 3;
            this.AddItem.Text = "添加商品明细";
            this.AddItem.UseVisualStyleBackColor = true;
            this.AddItem.Click += new System.EventHandler(this.AddItemToOrder_Click);
            // 
            // WarningNull
            // 
            this.WarningNull.AutoSize = true;
            this.WarningNull.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.WarningNull.ForeColor = System.Drawing.Color.Red;
            this.WarningNull.Location = new System.Drawing.Point(62, 9);
            this.WarningNull.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WarningNull.Name = "WarningNull";
            this.WarningNull.Size = new System.Drawing.Size(109, 12);
            this.WarningNull.TabIndex = 4;
            this.WarningNull.Text = "客户名不能为空！";
            this.WarningNull.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 371);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "当前总价：";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSize = true;
            this.TotalPrice.Location = new System.Drawing.Point(75, 371);
            this.TotalPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(65, 12);
            this.TotalPrice.TabIndex = 6;
            this.TotalPrice.Text = "TotalPrice";
            // 
            // ConfirmOrder
            // 
            this.ConfirmOrder.Location = new System.Drawing.Point(251, 366);
            this.ConfirmOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ConfirmOrder.Name = "ConfirmOrder";
            this.ConfirmOrder.Size = new System.Drawing.Size(65, 22);
            this.ConfirmOrder.TabIndex = 7;
            this.ConfirmOrder.Text = "确认订单";
            this.ConfirmOrder.UseVisualStyleBackColor = true;
            this.ConfirmOrder.Click += new System.EventHandler(this.ConfirmOrder_Click);
            // 
            // Warning1
            // 
            this.Warning1.AutoSize = true;
            this.Warning1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Warning1.ForeColor = System.Drawing.Color.Red;
            this.Warning1.Location = new System.Drawing.Point(207, 404);
            this.Warning1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Warning1.Name = "Warning1";
            this.Warning1.Size = new System.Drawing.Size(109, 12);
            this.Warning1.TabIndex = 8;
            this.Warning1.Text = "客户名不能为空！";
            this.Warning1.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.itemBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(11, 68);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(305, 286);
            this.dataGridView1.TabIndex = 9;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "商品名";
            this.itemNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            this.itemNameDataGridViewTextBoxColumn.Width = 66;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "单价";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 54;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "购买总数";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.Width = 78;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "totalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "总价";
            this.totalPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalPriceDataGridViewTextBoxColumn.Width = 54;
            // 
            // itemBindingSource1
            // 
            this.itemBindingSource1.DataSource = typeof(H5.OrderItem);
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 421);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Warning1);
            this.Controls.Add(this.ConfirmOrder);
            this.Controls.Add(this.TotalPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WarningNull);
            this.Controls.Add(this.AddItem);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(340, 460);
            this.MinimumSize = new System.Drawing.Size(340, 460);
            this.Name = "AddOrder";
            this.Text = "添加订单";
            this.Load += new System.EventHandler(this.AddOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CustomerName;
        private System.Windows.Forms.Button AddItem;
        private System.Windows.Forms.Label WarningNull;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TotalPrice;
        private System.Windows.Forms.Button ConfirmOrder;
        private System.Windows.Forms.Label Warning1;
        private System.Windows.Forms.BindingSource itemBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
    }
}