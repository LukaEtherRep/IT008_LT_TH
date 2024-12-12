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
    public partial class Cau22 : Form
    {
        public Cau22()
        {
            InitializeComponent();
        }

        private void Cau22_Load(object sender, EventArgs e)
        {
            lstvListInfo.Columns[0].Width = (int)(lstvListInfo.Width * 0.2);
            lstvListInfo.Columns[1].Width = (int)(lstvListInfo.Width * 0.13);
            lstvListInfo.Columns[2].Width = (int)(lstvListInfo.Width * 0.55);
            lstvListInfo.Columns[3].Width = (int)(lstvListInfo.Width * 0.118);
            lstvListInfo.View = View.Details;
            lstvListInfo.GridLines = true;
            lstvListInfo.FullRowSelect = true;
            lstvListInfo.MultiSelect = true;

            txbName.Text = "Nguyễn Thị Bạch Tạng";
            dtpickerBornDate.Value = new DateTime(2005, 10, 19);
            dtpickerBornDate.Format = DateTimePickerFormat.Short;
            txbPhoneNum.Text = "0338452907";
            txbAddress.Text = "13e/1, Đ.HT22, Ph.Hiệp Thành, Q.12, Tp.Hồ Chí Minh, Việt Nam";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbName.Text) || string.IsNullOrEmpty(txbPhoneNum.Text) || string.IsNullOrEmpty(txbAddress.Text))
            {
                MessageBox.Show("Không được để trống ô nhập dữ liệu");
                return;
            }
            ListViewItem listViewItem = lstvListInfo.Items.Add(txbName.Text);
            listViewItem.SubItems.Add(dtpickerBornDate.Text);
            listViewItem.SubItems.Add(txbAddress.Text);
            listViewItem.SubItems.Add(txbPhoneNum.Text);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (lstvListInfo.SelectedItems.Count == 1)
            {
                ListViewItem listViewItem = lstvListInfo.SelectedItems[0];
                listViewItem.SubItems[0].Text = txbName.Text;
                listViewItem.SubItems[1].Text = dtpickerBornDate.Text;
                listViewItem.SubItems[2].Text = txbAddress.Text;
                listViewItem.SubItems[3].Text = txbPhoneNum.Text;
            }
            else
            {
                MessageBox.Show("Chỉ được chọn 1 dòng để sửa");
            }
        }

        private void lstvListInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvListInfo.SelectedItems.Count == 1)
            {
                ListViewItem selectedLVI = lstvListInfo.SelectedItems[0];
                txbName.Text = selectedLVI.SubItems[0].Text;
                dtpickerBornDate.Text = selectedLVI.SubItems[1].Text;
                txbAddress.Text = selectedLVI.SubItems[2].Text;
                txbPhoneNum.Text = selectedLVI.SubItems[3].Text;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selectedLVIC = lstvListInfo.SelectedItems;
            if (selectedLVIC.Count > 0)
            {
                int count = selectedLVIC.Count;
                for (int i = count - 1; i >= 0; i--)
                    lstvListInfo.Items.Remove(selectedLVIC[i]);
            }
            else
            {
                MessageBox.Show("Chọn ít nhất 1 dòng");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
