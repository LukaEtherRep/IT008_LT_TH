using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTH_HOTEN_MSSV
{
    public partial class MDIForm : Form
    {
        public MDIForm()
        {
            InitializeComponent();
        }

        private void tsmiCau18_Click(object sender, EventArgs e)
        {
            Cau18 f = new Cau18();
            f.Show();
        }

        private void cau22ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cau22 f = new Cau22();
            f.Show();
        }

        private void cau19ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cau19 f = new Cau19();
            f.Show();
        }
    }
}
