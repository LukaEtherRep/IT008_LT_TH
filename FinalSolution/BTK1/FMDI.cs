using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTK1
{
    public partial class FMDI : Form
    {
        public FMDI()
        {
            InitializeComponent();
        }

        private void tsmiTask10_Click(object sender, EventArgs e)
        {
            Cau10 f = new Cau10();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void tsmiTask13_Click(object sender, EventArgs e)
        {
            Cau13 f = new Cau13();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void cau12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cau12 f = new Cau12();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void cau17ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cau17 f = new Cau17();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void cau14ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cau14 f = new Cau14();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void cau20ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cau20 cau20 = new Cau20();
            cau20.StartPosition = FormStartPosition.CenterScreen;
            cau20.Show();
        }

        private void cau25ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cau25 f = new Cau25();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void cauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cau26 f = new Cau26();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }
    }
}
