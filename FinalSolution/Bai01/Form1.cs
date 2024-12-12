using Bai05;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tsmiBai1_Click(object sender, EventArgs e)
        {
            Bai1 f = new Bai1();
            f.MdiParent = this;
            f.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmiBai5_Click(object sender, EventArgs e)
        {
            Bai5 f = new Bai5();
            f.Show();
        }

        private void tsmiBai7_Click(object sender, EventArgs e)
        {
            Bai7 f = new Bai7();
            f.Show();
        }

        private void bai8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai8 f = new Bai8();
            f.Show();
        }
    }
}
