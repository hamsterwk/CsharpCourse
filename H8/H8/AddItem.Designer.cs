namespace H8
{
    partial class AddItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItem));
            this.ItemName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.itemNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.itemPrice = new System.Windows.Forms.TextBox();
            this.ConfirmItem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Warning3 = new System.Windows.Forms.Label();
            this.Warning0 = new System.Windows.Forms.Label();
            this.Warning2 = new System.Windows.Forms.Label();
            this.Warning1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemName
            // 
            this.ItemName.Location = new System.Drawing.Point(88, 32);
            this.ItemName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(76, 21);
            this.ItemName.TabIndex = 0;
            this.ItemName.TextChanged += new System.EventHandler(this.ItemName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "商品名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "商品数量";
            // 
            // itemNum
            // 
            this.itemNum.Location = new System.Drawing.Point(88, 72);
            this.itemNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.itemNum.Name = "itemNum";
            this.itemNum.Size = new System.Drawing.Size(76, 21);
            this.itemNum.TabIndex = 2;
            this.itemNum.TextChanged += new System.EventHandler(this.itemNum_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "商品单价";
            // 
            // itemPrice
            // 
            this.itemPrice.Location = new System.Drawing.Point(88, 111);
            this.itemPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.itemPrice.Name = "itemPrice";
            this.itemPrice.Size = new System.Drawing.Size(76, 21);
            this.itemPrice.TabIndex = 4;
            this.itemPrice.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ConfirmItem
            // 
            this.ConfirmItem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ConfirmItem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ConfirmItem.Location = new System.Drawing.Point(73, 154);
            this.ConfirmItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ConfirmItem.Name = "ConfirmItem";
            this.ConfirmItem.Size = new System.Drawing.Size(56, 24);
            this.ConfirmItem.TabIndex = 6;
            this.ConfirmItem.Text = "确认";
            this.ConfirmItem.UseVisualStyleBackColor = true;
            this.ConfirmItem.Click += new System.EventHandler(this.ConfirmItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Warning3);
            this.panel1.Controls.Add(this.Warning0);
            this.panel1.Controls.Add(this.Warning2);
            this.panel1.Controls.Add(this.Warning1);
            this.panel1.Controls.Add(this.ConfirmItem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ItemName);
            this.panel1.Controls.Add(this.itemPrice);
            this.panel1.Controls.Add(this.itemNum);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(9, 82);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.MaximumSize = new System.Drawing.Size(200, 200);
            this.panel1.MinimumSize = new System.Drawing.Size(200, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 200);
            this.panel1.TabIndex = 7;
            // 
            // Warning3
            // 
            this.Warning3.AutoSize = true;
            this.Warning3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Warning3.ForeColor = System.Drawing.Color.Red;
            this.Warning3.Location = new System.Drawing.Point(34, 175);
            this.Warning3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Warning3.Name = "Warning3";
            this.Warning3.Size = new System.Drawing.Size(161, 12);
            this.Warning3.TabIndex = 10;
            this.Warning3.Text = "有项目填写错误，请修正！";
            this.Warning3.Visible = false;
            // 
            // Warning0
            // 
            this.Warning0.AutoSize = true;
            this.Warning0.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Warning0.ForeColor = System.Drawing.Color.Red;
            this.Warning0.Location = new System.Drawing.Point(38, 54);
            this.Warning0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Warning0.Name = "Warning0";
            this.Warning0.Size = new System.Drawing.Size(109, 12);
            this.Warning0.TabIndex = 9;
            this.Warning0.Text = "商品名不能为空！";
            this.Warning0.Visible = false;
            this.Warning0.Click += new System.EventHandler(this.Warning0_Click);
            // 
            // Warning2
            // 
            this.Warning2.AutoSize = true;
            this.Warning2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Warning2.ForeColor = System.Drawing.Color.Red;
            this.Warning2.Location = new System.Drawing.Point(34, 134);
            this.Warning2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Warning2.Name = "Warning2";
            this.Warning2.Size = new System.Drawing.Size(148, 12);
            this.Warning2.TabIndex = 8;
            this.Warning2.Text = "输入非法，请重新输入！";
            this.Warning2.Visible = false;
            // 
            // Warning1
            // 
            this.Warning1.AutoSize = true;
            this.Warning1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Warning1.ForeColor = System.Drawing.Color.Red;
            this.Warning1.Location = new System.Drawing.Point(34, 97);
            this.Warning1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Warning1.Name = "Warning1";
            this.Warning1.Size = new System.Drawing.Size(148, 12);
            this.Warning1.TabIndex = 7;
            this.Warning1.Text = "输入非法，请重新输入！";
            this.Warning1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(24, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "请输入订单明细";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 281);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(230, 320);
            this.MinimumSize = new System.Drawing.Size(230, 320);
            this.Name = "AddItem";
            this.Text = "添加订单明细";
            this.Load += new System.EventHandler(this.AddItem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ItemName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox itemNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox itemPrice;
        private System.Windows.Forms.Button ConfirmItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Warning2;
        private System.Windows.Forms.Label Warning1;
        private System.Windows.Forms.Label Warning0;
        private System.Windows.Forms.Label Warning3;
    }
}