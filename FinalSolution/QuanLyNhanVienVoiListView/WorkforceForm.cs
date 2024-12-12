using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanVienVoiListView
{
    public partial class WorkforceForm : Form
    {
        #region Static Fields
        public static string loginName;
        #endregion Static Fields

        public WorkforceForm()
        {
            LoginForm f = new LoginForm();
            f.ShowDialog();
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbHometown.Text) || string.IsNullOrEmpty(txbName.Text))
                return;
            ListViewItem item = new ListViewItem(txbName.Text);
            item.SubItems.Add(dtpickerBornDate.Text);
            item.SubItems.Add(rdbtnMale.Checked ? rdbtnMale.Text : rdbtnFemale.Text);
            item.SubItems.Add(cbHometown.Text);

            lstvWorker.Items.Add(item);
            txbName.Text = "";
            txbName.Focus();
        }

        private void WorkforceForm_Load(object sender, EventArgs e)
        {
            txbUserName.Text = loginName;
            lstvWorker.Columns[0].Width = (int)(lstvWorker.Width * 0.3);
            lstvWorker.Columns[1].Width = (int)(lstvWorker.Width * 0.2);
            lstvWorker.Columns[2].Width = (int)(lstvWorker.Width * 0.1);
            lstvWorker.Columns[3].Width = (int)(lstvWorker.Width * 0.3971);

            rdbtnMale.Checked = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selectedLVIC = lstvWorker.SelectedItems;
            if (selectedLVIC.Count > 0)
            {
                for (int i = selectedLVIC.Count - 1; i >= 0; i--)
                {
                    lstvWorker.Items.RemoveAt(selectedLVIC[i].Index);
                }
            }
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter:
                    btnAdd.PerformClick();
                    return true;
                case Keys.Delete:
                    btnDelete.PerformClick();
                    return true;
            }

            return base.ProcessDialogKey(keyData);
        }

        private void lstvWorker_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selectedLVIC = lstvWorker.SelectedItems;
            if (selectedLVIC.Count == 1)
            {
                ListViewItem item = selectedLVIC[0];
                txbName.Text = item.SubItems[0].Text;
                dtpickerBornDate.Text = item.SubItems[1].Text;
                if (item.SubItems[2].Text == "Nam")
                {
                    rdbtnMale.Checked = true;
                }
                else
                {
                    rdbtnFemale.Checked = true;
                }
                cbHometown.Text = item.SubItems[3].Text;
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection items = lstvWorker.SelectedItems;
            if (items.Count == 1)
            {
                ListViewItem item = items[0];
                item.SubItems[0].Text = txbName.Text;
                item.SubItems[1].Text = dtpickerBornDate.Text;
                item.SubItems[3].Text = cbHometown.Text;
                item.SubItems[2].Text = rdbtnMale.Checked ? rdbtnMale.Text : rdbtnFemale.Text;
            }
        }
    }
}
