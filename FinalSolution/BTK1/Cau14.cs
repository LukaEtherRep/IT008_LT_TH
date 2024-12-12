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
    public partial class Cau14 : Form
    {
        public Cau14()
        {
            InitializeComponent();
        }

        private void UpdateEvent()
        {
            txbName.Focus();
            if (string.IsNullOrEmpty(txbName.Text) == false)
            {
                lstbA.Items.Add(txbName.Text);
                txbName.Clear();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateEvent();
        }

        private void Cau14_Load(object sender, EventArgs e)
        {

        }

        private void btnToRight_Click(object sender, EventArgs e)
        {
            while (lstbA.SelectedIndices.Count > 0)
            {
                ListBox.SelectedIndexCollection dsI = lstbA.SelectedIndices;
                lstbB.Items.Add(lstbA.Items[lstbA.SelectedIndices[0]]);
                lstbA.Items.RemoveAt(dsI[0]);
            }
        }

        private void btnToLeft_Click(object sender, EventArgs e)
        {
            while (lstbB.SelectedIndices.Count > 0)
            {
                ListBox.SelectedIndexCollection dsI = lstbB.SelectedIndices;
                lstbA.Items.Add(lstbB.Items[lstbB.SelectedIndices[0]]);
                lstbB.Items.RemoveAt(dsI[0]);
            }
        }

        private void btnDoubleToRight_Click(object sender, EventArgs e)
        {
            lstbB.Items.AddRange(lstbA.Items);
            lstbA.Items.Clear();
        }

        private void btnDoubleToLeft_Click(object sender, EventArgs e)
        {
            lstbA.Items.AddRange(lstbB.Items);
            lstbB.Items.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txbName.Text = null;
            lstbA.Items.Clear();
            lstbB.Items.Clear();
            txbName.Focus();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            txbName.Focus();
            this.Close();
        }

        private void Cau14_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlgr = MessageBox.Show("Đóng form??", "Form closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dlgr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch(keyData)
            {
                case Keys.Enter:
                    UpdateEvent();
                    return true;
            }

            return base.ProcessDialogKey(keyData);
        }
    }
}
