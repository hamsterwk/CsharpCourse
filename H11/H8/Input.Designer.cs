namespace H8
{
    partial class Input
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Input));
            this.label1 = new System.Windows.Forms.Label();
            this.Warning = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入修改的值：";
            // 
            // Warning
            // 
            this.Warning.AutoSize = true;
            this.Warning.ForeColor = System.Drawing.Color.Red;
            this.Warning.Location = new System.Drawing.Point(55, 79);
            this.Warning.Name = "Warning";
            this.Warning.Size = new System.Drawing.Size(65, 12);
            this.Warning.TabIndex = 1;
            this.Warning.Text = "输入非法！";
            this.Warning.Visible = false;
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(43, 55);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(100, 21);
            this.inputBox.TabIndex = 2;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(57, 94);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmButton.TabIndex = 3;
            this.ConfirmButton.Text = "确认";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::H8.Properties.Resources.Add_up_figures__Ham_Ham13;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(2, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(59, 48);
            this.panel1.TabIndex = 4;
            // 
            // Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 161);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.Warning);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(200, 200);
            this.MinimumSize = new System.Drawing.Size(200, 200);
            this.Name = "Input";
            this.Text = "请输入数值";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Warning;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Panel panel1;
    }
}