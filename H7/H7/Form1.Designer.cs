namespace H7
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Warning1 = new System.Windows.Forms.Label();
            this.Warning2 = new System.Windows.Forms.Label();
            this.StepLabel = new System.Windows.Forms.Label();
            this.stepText = new System.Windows.Forms.TextBox();
            this.Warning3 = new System.Windows.Forms.Label();
            this.leftper = new System.Windows.Forms.Label();
            this.lengLeft = new System.Windows.Forms.TextBox();
            this.Warning4 = new System.Windows.Forms.Label();
            this.lengRight = new System.Windows.Forms.TextBox();
            this.Warning6 = new System.Windows.Forms.Label();
            this.thetaRight = new System.Windows.Forms.TextBox();
            this.Warning5 = new System.Windows.Forms.Label();
            this.theta1 = new System.Windows.Forms.Label();
            this.thetaLeft = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.theta2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(904, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(670, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(597, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "递归深度";
            // 
            // Warning1
            // 
            this.Warning1.AutoSize = true;
            this.Warning1.ForeColor = System.Drawing.Color.Red;
            this.Warning1.Location = new System.Drawing.Point(670, 123);
            this.Warning1.Name = "Warning1";
            this.Warning1.Size = new System.Drawing.Size(67, 15);
            this.Warning1.TabIndex = 3;
            this.Warning1.Text = "警告信息";
            this.Warning1.Visible = false;
            // 
            // Warning2
            // 
            this.Warning2.AutoSize = true;
            this.Warning2.ForeColor = System.Drawing.Color.Red;
            this.Warning2.Location = new System.Drawing.Point(879, 123);
            this.Warning2.Name = "Warning2";
            this.Warning2.Size = new System.Drawing.Size(67, 15);
            this.Warning2.TabIndex = 6;
            this.Warning2.Text = "警告信息";
            this.Warning2.Visible = false;
            // 
            // StepLabel
            // 
            this.StepLabel.AutoSize = true;
            this.StepLabel.Location = new System.Drawing.Point(836, 94);
            this.StepLabel.Name = "StepLabel";
            this.StepLabel.Size = new System.Drawing.Size(37, 15);
            this.StepLabel.TabIndex = 5;
            this.StepLabel.Text = "步长";
            // 
            // stepText
            // 
            this.stepText.Location = new System.Drawing.Point(879, 91);
            this.stepText.Name = "stepText";
            this.stepText.Size = new System.Drawing.Size(100, 25);
            this.stepText.TabIndex = 4;
            this.stepText.TextChanged += new System.EventHandler(this.stepText_TextChanged);
            // 
            // Warning3
            // 
            this.Warning3.AutoSize = true;
            this.Warning3.ForeColor = System.Drawing.Color.Red;
            this.Warning3.Location = new System.Drawing.Point(670, 176);
            this.Warning3.Name = "Warning3";
            this.Warning3.Size = new System.Drawing.Size(67, 15);
            this.Warning3.TabIndex = 9;
            this.Warning3.Text = "警告信息";
            this.Warning3.Visible = false;
            // 
            // leftper
            // 
            this.leftper.AutoSize = true;
            this.leftper.Location = new System.Drawing.Point(567, 147);
            this.leftper.Name = "leftper";
            this.leftper.Size = new System.Drawing.Size(97, 15);
            this.leftper.TabIndex = 8;
            this.leftper.Text = "左分支长度比";
            // 
            // lengLeft
            // 
            this.lengLeft.Location = new System.Drawing.Point(670, 144);
            this.lengLeft.Name = "lengLeft";
            this.lengLeft.Size = new System.Drawing.Size(100, 25);
            this.lengLeft.TabIndex = 7;
            this.lengLeft.TextChanged += new System.EventHandler(this.lengLeft_TextChanged);
            // 
            // Warning4
            // 
            this.Warning4.AutoSize = true;
            this.Warning4.ForeColor = System.Drawing.Color.Red;
            this.Warning4.Location = new System.Drawing.Point(879, 173);
            this.Warning4.Name = "Warning4";
            this.Warning4.Size = new System.Drawing.Size(67, 15);
            this.Warning4.TabIndex = 12;
            this.Warning4.Text = "警告信息";
            this.Warning4.Visible = false;
            this.Warning4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lengRight
            // 
            this.lengRight.Location = new System.Drawing.Point(879, 141);
            this.lengRight.Name = "lengRight";
            this.lengRight.Size = new System.Drawing.Size(100, 25);
            this.lengRight.TabIndex = 10;
            this.lengRight.TextChanged += new System.EventHandler(this.lengRight_TextChanged);
            // 
            // Warning6
            // 
            this.Warning6.AutoSize = true;
            this.Warning6.ForeColor = System.Drawing.Color.Red;
            this.Warning6.Location = new System.Drawing.Point(879, 223);
            this.Warning6.Name = "Warning6";
            this.Warning6.Size = new System.Drawing.Size(67, 15);
            this.Warning6.TabIndex = 18;
            this.Warning6.Text = "警告信息";
            this.Warning6.Visible = false;
            // 
            // thetaRight
            // 
            this.thetaRight.Location = new System.Drawing.Point(879, 191);
            this.thetaRight.Name = "thetaRight";
            this.thetaRight.Size = new System.Drawing.Size(100, 25);
            this.thetaRight.TabIndex = 16;
            this.thetaRight.TextChanged += new System.EventHandler(this.thetaRight_TextChanged);
            // 
            // Warning5
            // 
            this.Warning5.AutoSize = true;
            this.Warning5.ForeColor = System.Drawing.Color.Red;
            this.Warning5.Location = new System.Drawing.Point(670, 226);
            this.Warning5.Name = "Warning5";
            this.Warning5.Size = new System.Drawing.Size(67, 15);
            this.Warning5.TabIndex = 15;
            this.Warning5.Text = "警告信息";
            this.Warning5.Visible = false;
            // 
            // theta1
            // 
            this.theta1.AutoSize = true;
            this.theta1.Location = new System.Drawing.Point(582, 197);
            this.theta1.Name = "theta1";
            this.theta1.Size = new System.Drawing.Size(82, 15);
            this.theta1.TabIndex = 14;
            this.theta1.Text = "左分支角度";
            // 
            // thetaLeft
            // 
            this.thetaLeft.Location = new System.Drawing.Point(670, 194);
            this.thetaLeft.Name = "thetaLeft";
            this.thetaLeft.Size = new System.Drawing.Size(100, 25);
            this.thetaLeft.TabIndex = 13;
            this.thetaLeft.TextChanged += new System.EventHandler(this.thetaLeft_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(776, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "右分支长度比";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // theta2
            // 
            this.theta2.AutoSize = true;
            this.theta2.Location = new System.Drawing.Point(791, 197);
            this.theta2.Name = "theta2";
            this.theta2.Size = new System.Drawing.Size(82, 15);
            this.theta2.TabIndex = 20;
            this.theta2.Text = "右分支角度";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(3, 16);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 19);
            this.radioButton1.TabIndex = 21;
            this.radioButton1.Text = "蓝色";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(152, 16);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(58, 19);
            this.radioButton2.TabIndex = 22;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "红色";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(3, 41);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(58, 19);
            this.radioButton3.TabIndex = 23;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "绿色";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(152, 41);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(58, 19);
            this.radioButton4.TabIndex = 24;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "黑色";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Location = new System.Drawing.Point(673, 260);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 99);
            this.panel1.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(597, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "画笔颜色";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.theta2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Warning6);
            this.Controls.Add(this.thetaRight);
            this.Controls.Add(this.Warning5);
            this.Controls.Add(this.theta1);
            this.Controls.Add(this.thetaLeft);
            this.Controls.Add(this.Warning4);
            this.Controls.Add(this.lengRight);
            this.Controls.Add(this.Warning3);
            this.Controls.Add(this.leftper);
            this.Controls.Add(this.lengLeft);
            this.Controls.Add(this.Warning2);
            this.Controls.Add(this.StepLabel);
            this.Controls.Add(this.stepText);
            this.Controls.Add(this.Warning1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Warning1;
        private System.Windows.Forms.Label Warning2;
        private System.Windows.Forms.Label StepLabel;
        private System.Windows.Forms.TextBox stepText;
        private System.Windows.Forms.Label Warning3;
        private System.Windows.Forms.Label leftper;
        private System.Windows.Forms.TextBox lengLeft;
        private System.Windows.Forms.Label Warning4;
        private System.Windows.Forms.TextBox lengRight;
        private System.Windows.Forms.Label Warning6;
        private System.Windows.Forms.TextBox thetaRight;
        private System.Windows.Forms.Label Warning5;
        private System.Windows.Forms.Label theta1;
        private System.Windows.Forms.TextBox thetaLeft;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label theta2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}

