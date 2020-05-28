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
    public delegate void SendInfo(string input);
    public partial class Input : Form
    {
        public string type;
        public int lim;
        public Input()
        {
            InitializeComponent();
            type = "string";
            lim = 0;
        }
        public event SendInfo SendInfoEvent;

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            string text = inputBox.Text;
            if (type == "int")
            {
                if (OrderIO.CheckInt(0, text) < 0)
                {
                    Warning.Visible = true;
                    return;
                }
            }
            Warning.Visible = false;
            SendInfoEvent(text);
            this.Close();
        }
    }
}
