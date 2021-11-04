using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CV
{
    public partial class PingYi : Form
    {
        public int X = 0;
        public int Y = 0;
        public bool flag = false;
        public PingYi()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            flag = true;
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //关闭子窗口
            this.Close();
        }
    }
}
