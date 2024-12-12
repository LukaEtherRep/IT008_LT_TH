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
    public partial class Cau19 : Form
    {
        public Cau19()
        {
            InitializeComponent();
        }

        private void timerCount_Tick(object sender, EventArgs e)
        {
            lblRunString.Text = lblRunString.Text.Substring(1) + lblRunString.Text.Substring(0, 1);
        }

        private void txbPosition_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txbPosition_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txbPosition.Text))
            {
                btnAction.Enabled = false;
            }
            else
            {
                btnAction.Enabled = true;
            }
            //if(Convert.ToInt32(txbPosition.Text) > lbl)
        }

        private void Cau19_Load(object sender, EventArgs e)
        {
            lblRunString.Text = "                       Chương trình minh họa xử lý chuỗi trong C#                      ";
            txb1.Text = "Xử lý chuỗi # tập ! chương 5 Bài  Bài tập xử lý  #";
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            int viTri;
            viTri = Convert.ToInt32(txbPosition.Text);
            txb1.Text = txb1.Text.Insert(viTri, txb2.Text);
            txbPosition.Text = null;
        }

        private void btnChange23_Click(object sender, EventArgs e)
        {
            txb1.Text = txb1.Text.Replace(txb2.Text, txb3.Text);
        }

        private void btnDelete21_Click(object sender, EventArgs e)
        {
            int viTri = -1;
            viTri = txb1.Text.IndexOf(txb2.Text);
            while (viTri >= 0)
            {
                txb1.Text = txb1.Text.Remove(viTri, txb2.Text.Length);
                viTri = txb1.Text.IndexOf(txb2.Text, viTri);
            }
        }

        private void btnChange1_Click(object sender, EventArgs e)
        {
            string[] mangTu;
            char[] token = { ' ', ',', '\n', '\t', ';' };
            mangTu = txb1.Text.Split(token, StringSplitOptions.RemoveEmptyEntries);

            txb1.Text = "";
            for (int i = mangTu.Length - 1; i >= 0; i--)
            {
                txb1.Text += mangTu[i] + " ";
            }
            txb1.Text = txb1.Text.TrimEnd();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string[] mangTu;
            char[] token = { ' ', ',', '\n', '\t', ';' };
            mangTu = txb1.Text.Split(token, StringSplitOptions.RemoveEmptyEntries);

            string tu;
            txb1.Text = "";
            for (int i = 0; i < mangTu.Length; i++)
            {
                tu = mangTu[i];
                tu = tu.Substring(0, 1).ToUpper() + tu.Substring(1).ToLower();
                txb1.Text += tu + " ";
            }
            txb1.Text = txb1.Text.TrimEnd();
        }
    }
}
