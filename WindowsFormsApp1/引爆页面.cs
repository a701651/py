using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class 引爆页面 : Form
    {
        public 引爆页面()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            确认页面 f1 = new 确认页面();
            f1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
